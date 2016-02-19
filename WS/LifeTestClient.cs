using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using ND.DAL.WS.LifeTestService;
using ND.BO;
using System.Net.Sockets;

namespace ND.DAL.WS
{
    public class LifeTestClient
    {
        private static LifeTestClient instance;

        private LifeTestClient() { }

        public static LifeTestClient GetInstance
        {
            get
            {
                if (instance == null) instance = new LifeTestClient();
                return instance;
            }
        }

        public int GetLife(string serverName, int port)
        {
            ILifeTestService life = new LifeTestServiceClient("BasicHttpBinding_ILifeTestService", string.Format("http://{0}:{1}/Services/ILifeTestService", serverName, port));
            try
            {
                if (!PingHost(serverName,port)) return (int)LifeEnum.SERVER_NOT_EXISTS;
                return life.GetLifeTestResponse();
            }
            catch (EndpointNotFoundException)
            {
                return (int)LifeEnum.SERVER_NOT_FOUND;
            }
            catch (CommunicationException)
            {
                return (int)LifeEnum.SERVER_NOT_FOUND;
            }
            catch (Exception)
            {
                return (int)LifeEnum.SERVER_ERROR;
            }
        }

        private static bool PingHost(string _HostURI, int _PortNumber)
        {
            try
            {
                TcpClient client = new TcpClient(_HostURI, _PortNumber);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
