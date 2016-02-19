using ND.MonitorDasboard.Web.Config;
using ND.MonitorDasboard.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ND.MonitorDasboard.Web.Areas.Monitoring.Controllers
{
    public class LiveChartsController : Controller
    {
        // GET: Monitor
        public ActionResult Index()
        {
            ClustersModel model = new ClustersModel(MonitorDashoardConfiguration.Instance);

            return View(model);
        }
    }
}