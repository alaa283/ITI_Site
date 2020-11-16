using System.Web;
using System.Web.Optimization;

namespace _ITI
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

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                  "~/Scripts/_references.js",
                "~/Scripts/ai.0.22.9-build00167.js",
                "~/Scripts/ai.0.22.9-build00167.min.js",
                "~/Scripts/bootstrap.js",
                "~/Scripts/bootstrap.min.js",
                "~/Scripts/custom.js",
                "~/Scripts/jquery-1.10.2.intellisense.js",
                "~/Scripts/jquery-1.10.2.js",
                "~/Scripts/jquery-1.10.2.min.js",
                //"~/Scripts/jquery-1.10.2.min.map.js",
                "~/Scripts/jquery.counterup.js",
                "~/Scripts/jquery.fancybox.pack.js",
                "~/Scripts/jquery.min.js",
                "~/Scripts/jquery.mixitup.js",
                "~/Scripts/jquery.validate-vsdoc.js",
                "~/Scripts/jquery.validate.js",
                "~/Scripts/jquery.validate.min.js",
                "~/Scripts/jquery.validate.unobtrusive.js",
                "~/Scripts/jquery.validate.unobtrusive.min.js",
                "~/Scripts/modernizr-2.6.2.js",
                "~/Scripts/respond.js",
                "~/Scripts/respond.min.js",
                "~/Scripts/slick.js",
                "~/Scripts/waypoints.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/bootstrap.min.css",
                      "~/Content/font-awesome.css",
                      "~/Content/jquery.fancybox.css",
                      "~/Content/Site.css",
                      "~/Content/slick.css",
                      "~/Content/style.css",
                      "~/Content/theme-color/burlywood-theme.css",
                      "~/Content/theme-color/dark-red-theme.css",
                      "~/Content/theme-color/default-theme.css",
                      "~/Content/theme-color/green-theme.css",
                      "~/Content/theme-color/burlywood-theme.css",
                      "~/Content/theme-color/orange-theme.css",
                      "~/Content/theme-color/pink-theme.css",
                      "~/Content/theme-color/purple-theme.css",
                      "~/Content/theme-color/red-theme.css",
                      "~/Content/theme-color/violet-theme.css",
                      "~/Content/style1.css",
                      "~/Content/set.css"
                     //"~/Content/theme-color/yellow-theme.css"
                     ));


            bundles.Add(new ScriptBundle("~/scss/scss").Include(
                "~/scss/base/_base.scss",
                "~/scss/base/_mixins.scss",
                "~/scss/base/_variables.scss",
                "~/scss/layouts/_footer.scss",
                 "~/scss/layouts/_header.scss",
                  "~/scss/layouts/_nav.scss",
                  "~/scss/modeules/_buttons.scss",
                  "~/scss/modeules/_responsive.scss",
                  "~/scss/modeules/_sections.scss",
                  "~/scss/modeules/_theme-color.scss",
                  "~/scss/modeules/_typography.scss",
                  "~/scss/style.scss"));
        }
    }
}
