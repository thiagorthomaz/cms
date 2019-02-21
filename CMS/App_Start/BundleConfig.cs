using System.Web;
using System.Web.Optimization;

namespace CMS
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-3.1.1.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootbox").Include(
                      "~/Scripts/bootbox.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/adminlte/js").Include(
                      "~/admin-lte/js/adminlte.min.js"));

            bundles.Add(new StyleBundle("~/bundles/adminlte/css").Include(
                      "~/admin-lte/css/AdminLTE.min.css",
                      "~/admin-lte/css/skins/skin-blue.min.css"));

            bundles.Add(new StyleBundle("~/bundles/mediumeditor/css").Include(
                      "~/Content/mediumeditor/css/medium-editor.min.css",
                      "~/Content/mediumeditor/css/themes/default.min.css"));

            bundles.Add(new ScriptBundle("~/bundles/mediumeditor/js").Include(
                      "~/Content/mediumeditor/js/medium-editor.js"));

            bundles.Add(new ScriptBundle("~/bundles/datatables/js").Include(
                      "~/Content/datatables/datatables.min.js"));

            bundles.Add(new StyleBundle("~/bundles/datatables/css").Include(
                      "~/Content/datatables/datatables.min.css"));

        }
    }
}
