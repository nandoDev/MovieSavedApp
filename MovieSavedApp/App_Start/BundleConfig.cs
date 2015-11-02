using System.Web;
using System.Web.Optimization;

namespace MovieSavedApp
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-1.10.2.js",
                        "~/Scripts/jquery-ui-1.10.4.custom.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/jquery.min.js").Include(
                       "~/Scripts/jquery-1.10.2.min.js",
                       "~/Scripts/jquery-ui-1.10.4.custom.min.js"
                       ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                       "~/Scripts/jquery.unobtrusive*",
                       "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                     "~/Scripts/bootstrap.js",
                     "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/site").Include(
                     "~/Scripts/site.js"));

            bundles.Add(new ScriptBundle("~/bundles/chosen.jquery.js").Include(
                        "~/Scripts/chosen.jquery.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap.min.js").Include(
                        "~/Scripts/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/raphael-min.js").Include(
                        "~/Scripts/raphael-min.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/morris.min.js").Include(
                        "~/Scripts/plugins/morris/morris.min.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/jquery.sparkline.min.js").Include(
                        "~/Scripts/plugins/sparkline/jquery.sparkline.min.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/jquery-jvectormap-1.2.2.min.js").Include(
                        "~/Scripts/plugins/jvectormap/jquery-jvectormap-1.2.2.min.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/jquery-jvectormap-world-mill-en.js").Include(
                        "~/Scripts/plugins/jvectormap/jquery-jvectormap-world-mill-en.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/jquery.knob.js").Include(
                        "~/Scripts/plugins/jqueryKnob/jquery.knob.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/daterangepicker.js").Include(
                        "~/Scripts/plugins/daterangepicker/daterangepicker.js"
                        ));
            bundles.Add(new ScriptBundle("~/bundles/bootstrap-datepicker.js").Include(
                        "~/Scripts/plugins/datepicker/bootstrap-datepicker.js"
                        ));
            bundles.Add(new ScriptBundle("~/bundles/bootstrap3-wysihtml5.all.min.js").Include(
                        "~/Scripts/plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.all.min.js"
                        ));
            bundles.Add(new ScriptBundle("~/bundles/icheck.min.js").Include(
                        "~/Scripts/plugins/iCheck/icheck.min.js"
                        ));
            bundles.Add(new ScriptBundle("~/bundles/app.js").Include(
                        "~/Scripts/AdminLTE/app.js"
                        ));
            bundles.Add(new ScriptBundle("~/bundles/dashboard.js").Include(
                       "~/Scripts/AdminLTE/dashboard.js"
                       ));
            bundles.Add(new ScriptBundle("~/bundles/demo.js").Include(
                       "~/Scripts/AdminLTE/demo.js"
                       ));


            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/Site.css",
                "~/Content/bootstrap.css",
                "~/Content/css/estilos.css",
                "~/Content/main.css",
                "~/Content/ui-lightness/jquery-ui-{version}.custom.css"
                ));

            bundles.Add(new StyleBundle("~/Content/font-awesome.min.css").Include("~/Content/css/font-awesome.min.css"));

            bundles.Add(new StyleBundle("~/Content/ionicons.min.css").Include("~/Content/css/ionicons.min.css"));

            bundles.Add(new StyleBundle("~/Content/morris.css").Include("~/Content/css/morris/morris.css"));

            bundles.Add(new StyleBundle("~/Content/jvectormap/jquery-jvectormap-1.2.2.css").Include("~/Content/css/jvectormap/jquery-jvectormap-1.2.2.css"));

            bundles.Add(new StyleBundle("~/Content/datepicker3.css").Include("~/Content/css/datepicker/datepicker3.css"));

            bundles.Add(new StyleBundle("~/Content/daterangepicker-bs3.css").Include("~/Content/css/daterangepicker/daterangepicker-bs3.css"));

            bundles.Add(new StyleBundle("~/Content/bootstrap3-wysihtml5.min.css").Include("~/Content/css/bootstrap-wysihtml5/bootstrap3-wysihtml5.min.css"));

            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(

                        "~/Content/themes/base/jquery-ui.css",
                        "~/Content/themes/base/jquery-ui.all.css",
                        "~/Content/themes/base/jquery.ui.datepicker.css",
                        "~/Content/themes/base/jquery-ui.min.css",
                        "~/Content/themes/base/jquery.ui.core.css",
                        "~/Content/themes/base/jquery.ui.resizable.css",
                        "~/Content/themes/base/jquery.ui.selectable.css",
                        "~/Content/themes/base/jquery.ui.accordion.css",
                        "~/Content/themes/base/jquery.ui.autocomplete.css",
                        "~/Content/themes/base/jquery.ui.button.css",
                        "~/Content/themes/base/jquery.ui.dialog.css",
                        "~/Content/themes/base/jquery.ui.slider.css",
                        "~/Content/themes/base/jquery.ui.tabs.css",
                        "~/Content/themes/base/jquery.ui.datepicker.css",
                        "~/Content/themes/base/jquery.ui.progressbar.css",
                        "~/Content/themes/base/jquery.ui.theme.css"));

            bundles.Add(new StyleBundle("~/Content/themes/base").Include(
                        "~/Content/themes/base/base.css",
                        "~/Content/themes/base/all.css",
                        "~/Content/themes/base/sortable.css",
                        "~/Content/themes/base/spinner.css",
                        "~/Content/themes/base/tabs.css",
                        "~/Content/themes/base/draggable.css",
                        "~/Content/themes/base/core.css",
                        "~/Content/themes/base/menu.css",
                         "~/Content/themes/base/selectmenu.css",
                        "~/Content/themes/base/resizable.css",
                        "~/Content/themes/base/selectable.css",
                        "~/Content/themes/base/accordion.css",
                        "~/Content/themes/base/autocomplete.css",
                        "~/Content/themes/base/button.css",
                        "~/Content/themes/base/dialog.css",
                         "~/Content/themes/base/tooltip.css",
                        "~/Content/themes/base/slider.css",
                        "~/Content/themes/base/jquery.ui.tabs.css",
                        "~/Content/themes/base/datepicker.css",
                        "~/Content/themes/base/progressbar.css",
                        "~/Content/themes/base/theme.css"));
        }
    }
}
