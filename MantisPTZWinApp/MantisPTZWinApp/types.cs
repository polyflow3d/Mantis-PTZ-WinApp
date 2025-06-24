using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MantisPTZWinApp
{

        enum RUNTIME_DIAGNOSTIC_RESULT        
        { 
            CDR_successfull = 0,
            CDR_inProgress = 1,
            CDR_sensorLeftAboveMax = 2,
            CDR_sensorLeftBelowMin = 3,
            CDR_sensorRightAboveMax = 4,
            CDR_sensorRightBelowMin = 5, 
            CDR_noRemoteCommand = 6, 
            //CRITICAL BELOW  
            CDR_encoderLeftDisconnect = 7,  
            CDR_encoderRightDisconnect = 8,
            CDR_commandHorizontalAboveMax = 9,
            CDR_commandHorizontalBelowMin = 10,
            CDR_commandVerticalAboveMax = 11,
            CDR_commandVerticalBelowMin = 12,
            CDR_encoderLeftNoise = 13,  
            CDR_encoderRightNoise = 14,  
            CDR_motorLeftStalled = 15,
            CDR_motorRightStalled = 16,
            CDR_deltaTimeError = 17,
            CDR_driver0Overheat = 18,
            CDR_driver1Overheat = 19
        }  
            
    
        public enum REMOTE_STATE{ 
            RS_HeadDisconnected,
            RS_FirstTelemetryIsReceived,
            RS_GotInitialHeadAngles,
            RS_Normal_HeadInSlaveMode 
        }      
 
        [StructLayout(LayoutKind.Sequential)]
        public struct Command{ 
            public short horizonal;
            public short vertical;
            public byte relay0;
            public byte relay1;            
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Telemetry{ 
            public short horizonal;
            public short vertical;
            public byte headRuntimeDiagnosticEnum;
            public byte headPacketRateTelemetry;  
            public byte headPacketRateCommand;
            public byte remoteStateEnum;
            public short runtimeDiagnosticArgument;
            public byte commands_from_app_perseconds;

            public string GetString(){ 
                string result = "telem.:";
                result += string.Format(" h:{0} ", horizonal);
                result += string.Format(" v:{0} ", vertical);
                result += string.Format(" runtimeDig:{0} ", (RUNTIME_DIAGNOSTIC_RESULT)headRuntimeDiagnosticEnum);
                result += string.Format(" headPacketRateTelemetry:{0} ", headPacketRateTelemetry);
                result += string.Format(" remoteState :{0} ", (REMOTE_STATE)remoteStateEnum);
                result += string.Format(" commandsFromAppRate :{0} ",  commands_from_app_perseconds);
                return result;
            }
        }
}
