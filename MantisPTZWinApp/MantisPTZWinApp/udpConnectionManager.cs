using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Runtime.InteropServices;

namespace MantisPTZWinApp
{
    internal class udpConnectionManager
    {

        public class RecievedUDPPaket{ 
            public DateTime timestamp;
            public IPEndPoint packedSender;
            public byte[] recievedData; 
            public Telemetry telemetry;
        }

        public enum ConstructionResult{ 
            Undefined,
            Success,
            NotValidPortName
        }

 
        public ConstructionResult constructionResult{
            get{
                return _constructionResult;
            }
        }
         Socket s;
 
        ConstructionResult _constructionResult = ConstructionResult.Undefined;
        public string constructionSummary = ""; 
        private UdpClient udpclient0;
                private UdpClient udpclient2;
        private DateTime lastPacketRecievetimestamp;
        public TimeSpan deltaTimePacketRecieve;
        public int recievedPacketsCount;


        public udpConnectionManager( ){       
 
            // Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            udpclient0 = new UdpClient(1234);
            udpclient2 = new UdpClient(4321);
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse("192.168.88.253"), 4321);
            udpclient2.Connect(ep);
            constructionSummary = "udp listener started";
        }
 
        public RecievedUDPPaket Update(){
            if(udpclient0.Available>0){ 
                RecievedUDPPaket packet = new RecievedUDPPaket();
                packet.packedSender = new IPEndPoint(IPAddress.Any, 0);
                packet.recievedData = udpclient0.Receive(ref packet.packedSender); 
                packet.telemetry =  CastingHelper.CastToStruct<Telemetry>(packet.recievedData);
                //packet.timestamp = DateTime.Now;
                deltaTimePacketRecieve = DateTime.Now - lastPacketRecievetimestamp;
                lastPacketRecievetimestamp = DateTime.Now;
                recievedPacketsCount++;
                return packet;
            } 

            return null;
        }

        public void Dispose(){ 
            if(udpclient0!=null){ 
                udpclient0.Dispose();
                udpclient2.Dispose();
            }
        }


        public void SendPackage(Command command){ 

            IPAddress broadcast = IPAddress.Parse("192.168.88.253");
            IPEndPoint ep = new IPEndPoint(broadcast, 42);
            // = new byte[2+2+1+1];
            byte[] sendbuf = CastingHelper.CastToArray<Command>(command);
            Console.WriteLine(string.Format("length {0}", sendbuf.Length));
            //!!if(udpclient2.)
            udpclient2.Send(sendbuf, 6);
            //  s.SendTo(sendbuf, ep);
        }
    }


}
