using ND.MonitorDasboard.Web.Config;
using ND.MonitorDasboard.Web.Models;
using ND.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ND.MonitorDasboard.Web.WebAPI
{
    public class AppliController : ApiController
    {
        ClustersModel model = new ClustersModel(MonitorDashoardConfiguration.Instance);

        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            var applis = model.Clusters.First().Monitors.Select(m => m.ApplicationCode).ToList();

            return applis;

        }
    }
}