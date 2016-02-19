using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ND.MonitorDasboard.Web.Areas.Monitoring.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Monitoring/Dashboard
        public ActionResult Index()
        {
            return View();
        }
    }
}