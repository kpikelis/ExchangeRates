using BundleTransformer.Core.Resolvers;
using System.Web;
using System.Web.Optimization;

namespace SEB.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            BundleTable.EnableOptimizations = true;
            BundleResolver.Current = new CustomBundleResolver();

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css")
                .IncludeDirectory("~/Content", "*.css", true));

            //AngularJS Resources
            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                "~/Scripts/angular/angular.js",
                "~/Scripts/angular/angular-sanitize.js",
                "~/Scripts/angular/angular-route.min.js",
                "~/Scripts/angular/smart-table.min.js",
                "~/Scripts/angular-material/angular-material.min.js",
                "~/Scripts/angular-animate/angular-animate.min.js",
                "~/Scripts/angular-aria/angular-aria.min.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/sebApp")
                .IncludeDirectory("~/App", "*.js", true));

            bundles.Add(new ScriptBundle("~/bundles/exchangeRates").Include(
                "~/Areas/ExchangeRates/Scripts/exchangeRatesController.js",
                "~/Areas/ExchangeRates/Scripts/exchangeRatesService.js"
            ));

        }
    }
}
