using MongoDB.Bson;
using ND.BO;
using ND.DAL.MongoDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ND.Services
{
    public class MonitorService
    {
        public static void InsertResults(List<ClusterBO> clustersLife)
        {
            foreach (ClusterBO cluster in clustersLife)
            {
                foreach (MonitorBO monitor in cluster.Monitors)
                {
                    foreach (NodeBO node in monitor.Nodes)
                    {
                        MonitorResultBO res = new MonitorResultBO()
                        {
                            ApplicationCode = monitor.ApplicationCode,
                            ApplicationName = monitor.ApplicationName,
                            Environment = cluster.Environment,
                            MachineName = node.MachineName,
                            Result = node.LifeResult,
                            ResultDate = DateTime.Now
                        };
                        bool ret = MonitorDal.Insert(res).Result;
                    }
                }
            }
        }

        public static IList<MonitorResultBO> GetAll()
        {
            return MonitorDal.GetAll();
        }
        public static IList<MonitorResultBO> GetAllPaging(int pageIndex, int pageSize)
        {
            return MonitorDal.GetAllPaging(pageIndex, pageSize);
        }

        public static IList<MonitorResultBO> GetByAppAndEnv(string app, string env)
        {
            if (app != null && env != null)
                return MonitorDal.GetByAppAndEnv(app, env);
            else return null;
        }

        public static IList<StatBO> GetStatsResults(string app, string env)
        {
            return MonitorDal.GetStatsResults(app, env);
        }
    }
}
