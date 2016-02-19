using ND.MonitorDasboard.Web.Config;
using ND.MonitorDasboard.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ND.MonitorDasboard.Web.WebAPI
{
    /// <summary>
    /// Environment Controller
    /// </summary>
    public class EnvironmentController : ApiController
    {
        ClustersModel model = new ClustersModel(MonitorDashoardConfiguration.Instance);

        
        
        
        /// <summary>
        /// Get an array of string of Environments
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return model.Clusters.Select(x => x.Environment.Code);
        }
    }
}
