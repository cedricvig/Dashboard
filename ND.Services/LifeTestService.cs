using ND.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ND.DAL.WS;

namespace ND.Services
{
    public static class LifeTestService
    {
        public static void GetLifeTestOld(ref List<ClusterBO> clusters)
        {
            foreach (ClusterBO cluster in clusters)
            {
                foreach (MonitorBO monitor in cluster.Monitors)
                {
                    foreach (NodeBO node in monitor.Nodes)
                    {
                        node.LifeResult = LifeTestClient.GetInstance.GetLife(node.MachineName, monitor.RemotePort);
                    }
                }
            }
        }

        public static void GetLifeTest(ref List<ClusterBO> clusters)
        {
            foreach (ClusterBO cluster in clusters)
            {
                foreach (MonitorBO monitor in cluster.Monitors)
                {
                    foreach (NodeBO node in monitor.Nodes)
                    {
                        Task t = Task.Factory.StartNew(() =>
                            {
                                node.LifeResult = LifeTestClient.GetInstance.GetLife(node.MachineName, monitor.RemotePort);
                            });
                    }
                }
            }
        }
    }
}
