using Microsoft.AspNet.SignalR;
using ND.BO;
using ND.MonitorDasboard.Web.App_Start;
using ND.MonitorDasboard.Web.Schedule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ND.MonitorDasboard.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        private BackgroundServerLifeTimer bsft;

        protected void Application_Start()
        {
            bsft = new BackgroundServerLifeTimer();

            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);


        }
    }
}
