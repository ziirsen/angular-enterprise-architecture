using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Optimization;

namespace AngularEnterpriseArchitecture
{
    public class BundleConfig
    {
        private static string _appSourcePath = "dev";

        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            // Re-define variables based on build configuration
            #if !DEBUG
                    _appSourcePath = "prod";
            #endif

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                "~/Scripts/jquery.unobtrusive*",
                "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/bootstrap.js",
                "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                 "~/Content/bootstrap.css",
                 "~/Content/Site.css"));


            var coreBundle = new ScriptBundle("~/bundles/core").Include(
                   "~/Scripts/angular.js",
                   "~/Scripts/angular-route.js",
                   "~/Scripts/angular-cache.js",

                   "~/Scripts/require.js");

            // Application sub-modules
            bundles.Add(coreBundle.Include(
                      "~/App/" + _appSourcePath + "/app.js",
                      "~/App/" + _appSourcePath + "/pages/dashboard/module.config.js",
                      "~/App/" + _appSourcePath + "/pages/contact/module.config.js",
                      "~/App/" + _appSourcePath + "/pages/charts/module.config.js"
                      ));
        }
    }
}
