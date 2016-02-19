using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ND.BO
{
    public enum LifeEnum : int
    {
        SUCCESS = 200,
        TIMEOUT = 408,
        SERVER_ERROR = 500,
        SERVER_NOT_FOUND = 503,
        SERVER_NOT_EXISTS = 600
    }
}
