using ND.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ND.MonitorDasboard.Web.Models
{
    public class ClustersModel
    {
        public List<ClusterBO> Clusters { get; set; }

        public ClustersModel()
        {
        }


        public ClustersModel(ND.MonitorDasboard.Web.Config.MonitorDashoardConfiguration conf)
        {
            Clusters = new List<ClusterBO>();

            foreach (ND.MonitorDasboard.Web.Config.Cluster clust in conf.Clusters)
            {
                ClusterBO cBO = new ClusterBO()
                {
                    Label = clust.Label,
                    Environment = new EnvironmentBO()
                    {
                        Code = clust.Environment.Code,
                        Label = clust.Environment.Label
                    },
                    Monitors = new List<MonitorBO>()
                };

                List<MonitorBO> Monitors = new List<MonitorBO>();
                foreach (ND.MonitorDasboard.Web.Config.Monitor mon in conf.Monitors)
                {
                    MonitorBO monBo = new MonitorBO()
                    {
                        ApplicationCode = mon.ApplicationCode,
                        ApplicationName = mon.ApplicationName,
                        RemotePort = mon.RemotePort,
                        Nodes=new List<NodeBO>()
                    };
                    foreach (ND.MonitorDasboard.Web.Config.Node node in clust.Nodes)
                    {
                        NodeBO nBO = new NodeBO() { MachineName = node.MachineName };
                        monBo.Nodes.Add(nBO);
                    }
                    Monitors.Add(monBo);
                }               

                cBO.Monitors = Monitors;               
                Clusters.Add(cBO);
            }
        }
    }
}