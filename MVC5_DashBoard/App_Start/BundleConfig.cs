using System.Web;
using System.Web.Optimization;

namespace ND.MonitorDasboard.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            // Bootstrap framework -> Responsive design
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap*",
                      "~/Scripts/respond.js"));
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap*",
                      "~/Content/site.css",
                       "~/Content/ui-grid*",
                      "~/Content/ui-bootstrap-csp.css"));

            // SignalR framework and autogenerate Hubs -> Real Time communication between client and server
            bundles.Add(new ScriptBundle("~/bundles/SignalR").Include(
                      "~/Scripts/jquery.signalR-*",
                      "~/signalr/hubs"));

            // UI Bootstrap: native AngularJS directives based on Bootstrap's markup and CSS
            // https://angular-ui.github.io/bootstrap/
            bundles.Add(new ScriptBundle("~/bundles/angular-ui").IncludeDirectory("~/Scripts/angular-ui", "*.js"));


            // Angular HighCharts
            // https://github.com/pablojim/highcharts-ng
            bundles.Add(new ScriptBundle("~/bundles/HighCharts").Include(
                "~/Scripts/highcharts-ng.js",
                "~/Scripts/highcharts/highcharts.js"));

            // Angular UI Grid
            // http://ui-grid.info/
            bundles.Add(new ScriptBundle("~/bundles/angular-ui-grid").Include(
                "~/Scripts/ui-grid.js"));

            // AngularJs Framework and App Controllers -> Bidirectional Databinding
            bundles.Add(new ScriptBundle("~/bundles/angularjs").Include(
                       "~/Scripts/angular.js",
                       "~/Scripts/angular-resource.js",
                       "~/Scripts/angular-filter.js"));
            bundles.Add(new ScriptBundle("~/bundles/AngularMVCCtrls").IncludeDirectory("~/Scripts/AngularControllers", "*.js"));
            bundles.Add(new ScriptBundle("~/bundles/AngularMVCFActories").IncludeDirectory("~/Scripts/AngularFactories", "*.js"));
            bundles.Add(new ScriptBundle("~/bundles/AngularMVCApp").IncludeDirectory("~/Scripts/AngularApp", "*.js"));

          


        }
    }
}
