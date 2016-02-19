using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ND.BO
{
    public class ClusterBO
    {
        public string Label { get; set; }
        public EnvironmentBO  Environment { get; set; }
        public List<MonitorBO> Monitors { get; set; }
    }
}
