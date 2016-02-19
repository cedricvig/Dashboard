using ND.MonitorDasboard.Web.Schedule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ND.MonitorDasboard.Web.WebAPI
{
    public class PingRefreshController : ApiController
    {
        // GET api/<controller>
        public object Get()
        {
            return new  { value = BackgroundServerLifeTimer.PingActivated };
        }

        // POST api/<controller>
        public void Post([FromBody]bool value)
        {
            // update ping value
            BackgroundServerLifeTimer.RefreshPing(value);
        }
    }
}
