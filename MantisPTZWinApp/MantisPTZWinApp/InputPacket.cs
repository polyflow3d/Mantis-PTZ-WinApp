using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantisPTZWinApp {

    internal class InputPacket {

        public enum Result{ 
            Undefined,
            Valid,
            CRCError,
            LengthError
        }

        Result _result = Result.Undefined;
        public Result result{
            get{
                return _result;
            }
        }

        byte[] rawBytes = new byte[0];
        byte[] rawPayloadBytes = new byte[0];
        byte[] unpackedPayload = new byte[0];
        public ListViewItem lvi;

        bool _validPacket = false;
        public bool validPacket{
            get{
                return _validPacket;
            }
        }

        public int inputStructLength{ 
            get{
                return 8;
            }
        }

        public byte b_startByte{ 
            get{ 
                return rawBytes[0];
            }
        }

        public byte b_packetID {
            get {
                return rawBytes[1];
            }
        }

        public byte b_COBS {
            get {
                return rawBytes[2];
            }
        }

        public byte b_numberOfPayloadBytes{ 
            get {
                return rawBytes[3];
            }
        }

        public int payloadStartByteIdx {
            get {
                return 4;
            }
        }

        public byte b_CRC {
            get {
                return rawBytes[4+inputStructLength];
            }
        }

        public byte b_stopByte {
            get {
                return rawBytes[4 + inputStructLength+1];
            }
        }

        public int estimatedTotalPacketBytes{ 
            get{
                return 4 + inputStructLength + 2;
            }
        }

        byte _b_calculatedCRC;
        public byte b_calculatedCRC{ 
            get{
                return _b_calculatedCRC;
            }
        }

        public InputPacket(ulong packetNumber, DateTime timestamp, byte[] _bytes ) {
            lvi = new ListViewItem(packetNumber.ToString());

            if (_bytes.Length != estimatedTotalPacketBytes) {
                lvi.SubItems.Add( string.Format( "not valid length {0} est.{1}", _bytes.Length, estimatedTotalPacketBytes));
                _result = Result.LengthError;
                lvi.SubItems.Add("Length");
                return;
            }

            rawBytes = new byte[ estimatedTotalPacketBytes];
            rawPayloadBytes = new byte[ inputStructLength ];
            _bytes.CopyTo(rawBytes, 0);
            System.Array.Copy(_bytes, payloadStartByteIdx, rawPayloadBytes,0, inputStructLength);
            _b_calculatedCRC = Crc8.calculate(rawPayloadBytes);
            if(_b_calculatedCRC != b_CRC){
                _result = Result.CRCError;
                lvi.SubItems.Add("CRC Error");
                return;
            }
            unpackedPayload = new byte[rawPayloadBytes.Length];
            rawPayloadBytes.CopyTo(unpackedPayload, 0);

            int replaceIdx = b_COBS;
            Debug.Print("replaceIdx ={0} b_COBS = {1} b_cobsHex = {2}", replaceIdx, b_COBS, utils.ToHex(b_COBS));

            if(b_COBS != 0xFF){ 
                while(true){
                    byte unpackedBeforeReplace = unpackedPayload[replaceIdx];
                    unpackedPayload[replaceIdx] = b_startByte;
                    Debug.Print("  unpackedBeforeReplace(offset) {0} unpakedAfterReplace {1}", unpackedBeforeReplace, unpackedPayload[replaceIdx]);
 
                    if(unpackedBeforeReplace == 0){
                        break;
                    }
                    replaceIdx += unpackedBeforeReplace;
                }
            }
            
            /*
            if(replaceIdx < 255){
                while (true) {
                    if(replaceIdx >= unpackedPayload.Length){
                        Debug.Print(string.Format("replace idx ({0}) > length ({1})", replaceIdx, unpackedPayload.Length));
                        continue;
                    }
                    int nextReplacedIdx =  unpackedPayload[replaceIdx];
                    unpackedPayload[replaceIdx] = b_startByte;
                    replaceIdx += nextReplacedIdx;
                    if (replaceIdx == 0) {
                        break;
                    }
                }
            }*/

            lvi.SubItems.Add(timestamp.ToString("hh.mm.ss.ffffff"));
            lvi.SubItems.Add(  utils.ToHex(b_startByte));
            lvi.SubItems.Add( utils.ToHex(b_packetID) );
            lvi.SubItems.Add( utils.ToHex(b_COBS) );
            lvi.SubItems.Add( string.Format("{0} ({1})", utils.ToHex(b_numberOfPayloadBytes), (int)b_numberOfPayloadBytes ));
            for(int i = 0; i<inputStructLength; i++){
                 lvi.SubItems.Add( string.Format(" {1} ", utils.ToHex( rawPayloadBytes[i]), utils.ToHex(unpackedPayload[i]))  );
            }
            lvi.SubItems.Add( string.Format("{0} {1}",  utils.ToHex(b_CRC), utils.ToHex(b_calculatedCRC)) );
            lvi.SubItems.Add( utils.ToHex(b_stopByte));

            _result = Result.Valid;
            lvi.SubItems.Add(result.ToString());
        }
    }
}
