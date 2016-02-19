using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ND.MonitorDasboard.Web.Areas.Monitoring
{
    public class MonitoringAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Monitoring";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Monitoring_Default",
                "{controller}/{action}/{id}",
                new { area="Monitoring", controller = "Home", action = "Index", apiId = UrlParameter.Optional });
        }
    }
}