using ND.BO;
using ND.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ND.MonitorDasboard.Web.WebAPI
{
    public class DashboardController : ApiController
    {
        // Palette de couleur pour le pie chart
        private Dictionary<int, string> colors = new Dictionary<int, string>() { 
        { 0, "#FFFFFF" },
        { 200, "#0B8484" }, // OK
        { 408, "#B1D511" }, // TimeOut
        { 600, "#87051A" } // KO
        };

        // GET api/<controller>
        public IEnumerable<object> Get(string environmentCode, string applicationCode)
        {
            var dataChart = from d in MonitorService.GetStatsResults(applicationCode, environmentCode).ToList()
                            select new { name = d.Result, y = d.Count, color = colors[d.Result] };
            return dataChart;
        }
    }
}