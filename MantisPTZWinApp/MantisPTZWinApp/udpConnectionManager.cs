using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace MantisPTZWinApp
{
    internal class udpConnectionManager
    {

        public enum ConstructionResult{ 
            Undefined,
            Success,
            NotValidPortName
        }

        int listenPort;
        UdpClient listener;
        IPEndPoint groupEP;
        public ConstructionResult constructionResult{
            get{
                return _constructionResult;
            }
        }
 
        ConstructionResult _constructionResult = ConstructionResult.Undefined;
        public string connectionSummary = ""; 

        public udpConnectionManager(string port, string ipString){       
            IPAddress ia  = IPAddress.Any;
            bool portParsed =  int.TryParse(port,out listenPort);
            bool ipParced = IPAddress.TryParse(ipString,out ia);

            if(portParsed && ipParced){ 
                listener = new UdpClient(listenPort);
                groupEP = new IPEndPoint(ia, 0);
                _constructionResult = ConstructionResult.Success;
                connectionSummary = string.Format("UDP Listener started {0} port {1}", ia.ToString(), listenPort.ToString());
            } else { 
                  connectionSummary = string.Format("UDP Listener failed to start {0} {1}", portParsed?"":"Not Valid port",  ipParced?"": string.Format( "Not Valid IP: {0}", ipString ));
            }           
        }

        public byte[] Update(){
            byte[] result = null;
            if(listener.Available >0){ 
                result = listener.Receive(ref groupEP);
            }
            return result;
        }

        public void Dispose(){ 
            if(listener != null){ 
                listener.Close();
                listener.Dispose();
            }
        }
    }
}
