using System.Web;
using System.Web.Optimization;

namespace tbcng
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

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/datatable").Include(
                    "~/Content/admin/vendor/datatable/jquery.dataTables.min.js",
                    "~/Content/admin/vendor/datatable/dataTables.bootstrap.min.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/dropzonescripts").Include(
                     "~/Scripts/dropzone/dropzone.js"));

            bundles.Add(new StyleBundle("~/Content/dropzonescss").Include(
                     "~/Scripts/dropzone/basic.css",
                     "~/Scripts/dropzone/dropzone.css"));

            bundles.Add(new StyleBundle("~/Themes/default/Content/css/main").Include(
                    "~/Themes/default/Content/css/bootstrap.css",
                    "~/Themes/default/Content/css/range-slider.css",
                    "~/Themes/default/Content/css/owl.carousel.css",
                    "~/Themes/default/Content/css/prettyPhoto.css",
                    "~/Themes/default/Content/css/jquery.bxslider.css",
                    "~/Themes/default/Content/css/font-awesome.css",
                    "~/Themes/default/Content/css/svg.css",                   
                    "~/Themes/default/Content/css/widget.css",
                    "~/Themes/default/Content/css/typography.css",
                    "~/Themes/default/Content/css/shortcodes.css",
                    "~/Themes/default/Content/css/color.css",
                    "~/Themes/default/Content/css/responsive.css",
                    "~/Themes/default/Content/js/dl-menu/component.css"
                ));

            bundles.Add(new StyleBundle("~/Themes/default/Content/style").Include(
                    "~/Themes/default/Content/style.css"
                ));

            bundles.Add(new ScriptBundle("~/Themes/default/Content/js/main").Include(
                    "~/Themes/default/Content/js/range-slider.js",
                    "~/Themes/default/Content/js/bootstrap.js",
                    "~/Themes/default/Content/js/jquery.bxslider.js",
                    "~/Themes/default/Content/js/owl.carousel.js",
                    "~/Themes/default/Content/js/jquery.accordion.js",
                    "~/Themes/default/Content/js/jquery.downCount.js",
                    "~/Themes/default/Content/js/dl-menu/modernizr.custom.js",
                    "~/Themes/default/Content/js/dl-menu/jquery.dlmenu.js"
                ));

            bundles.Add(new ScriptBundle("~/Themes/default/Content/js/custom").Include(
                    "~/Themes/default/Content/js/custom.js"
                ));

            BundleTable.EnableOptimizations = true;
        }
    }
}
