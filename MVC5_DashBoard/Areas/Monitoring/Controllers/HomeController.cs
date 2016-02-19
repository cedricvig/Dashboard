using ND.BO;
using ND.MonitorDasboard.Web.Config;
using ND.MonitorDasboard.Web.Models;
using ND.Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace ND.MonitorDasboard.Web.Areas.Monitoring.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ClustersModel model = new ClustersModel(MonitorDashoardConfiguration.Instance);

            return View(model);
        }
    }
}