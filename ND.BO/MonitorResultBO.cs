using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ND.BO
{
    public class MonitorResultBO : MongoBase
    {
        public MonitorResultBO()
        { 
        }

        public DateTime ResultDate { get; set; }

        public string ApplicationCode { get; set; }
        public string ApplicationName { get; set; }

        public string MachineName { get; set; }

        public EnvironmentBO Environment { get; set; }

        public int Result { get; set; }


    }
}
