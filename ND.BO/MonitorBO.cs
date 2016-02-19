using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ND.BO
{
    public class MonitorBO
    {

        public List<NodeBO> Nodes { get; set; }
        public string ApplicationCode { get; set; }
        public string ApplicationName { get; set; }
        public int RemotePort { get; set; }
    }
}
