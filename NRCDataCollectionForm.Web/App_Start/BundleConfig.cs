using System.Web.Optimization;

namespace NRCDataCollectionForm.Web
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.IgnoreList.Clear();

            //VENDOR RESOURCES

            //~/Bundles/vendor/css
            bundles.Add(
                new StyleBundle("~/Bundles/vendor/css")
                    .Include("~/Content/themes/base/all.css", new CssRewriteUrlTransform())
                    .Include("~/Content/bootstrap-cosmo.min.css", new CssRewriteUrlTransform())
                    .Include("~/Content/toastr.min.css")
                    .Include("~/Scripts/sweetalert/sweet-alert.css")
                    .Include("~/Content/flags/famfamfam-flags.css", new CssRewriteUrlTransform())
                    .Include("~/Content/font-awesome.min.css", new CssRewriteUrlTransform())
                );

            //~/Bundles/vendor/js/top (These scripts should be included in the head of the page)
            bundles.Add(
                new ScriptBundle("~/Bundles/vendor/js/top")
                    .Include(
                        "~/Abp/Framework/scripts/utils/ie10fix.js",
                        "~/Scripts/modernizr-2.8.3.js"
                    )
                );

            //~/Bundles/vendor/bottom (Included in the bottom for fast page load)
            bundles.Add(
                new ScriptBundle("~/Bundles/vendor/js/bottom")
                    .Include(
                        "~/Scripts/json2.min.js",

                        "~/Scripts/jquery-3.6.0.min.js",
                        "~/Scripts/jquery-ui-1.12.1.min.js",

                        "~/Scripts/bootstrap.min.js",

                        "~/Scripts/moment-with-locales.min.js",
                        "~/Scripts/jquery.validate.min.js",
                        "~/Scripts/jquery.blockUI.js",
                        "~/Scripts/toastr.min.js",
                        "~/Scripts/sweetalert/sweet-alert.min.js",
                        "~/Scripts/others/spinjs/spin.js",
                        "~/Scripts/others/spinjs/jquery.spin.js",

                        "~/Content/themes/Plugins/Angular/angular.min.js",
                        "~/Content/themes/Plugins/Angular/angular-animate.min.js",
                        "~/Content/themes/Plugins/Angular/angular-sanitize.min.js",
                        "~/Content/themes/Plugins/Angular/angular-ui-router.min.js",
                        "~/Content/themes/Plugins/Angular/angular-ui/ui-bootstrap.min.js",
                        "~/Content/themes/Plugins/Angular/angular-ui/ui-bootstrap-tpls.min.js",
                        "~/Content/themes/Plugins/Angular/angular-ui/ui-utils.min.js",

                        "~/Abp/Framework/scripts/abp.js",
                        "~/Abp/Framework/scripts/libs/abp.jquery.js",
                        "~/Abp/Framework/scripts/libs/abp.toastr.js",
                        "~/Abp/Framework/scripts/libs/abp.blockUI.js",
                        "~/Abp/Framework/scripts/libs/abp.sweet-alert.js",
                        "~/Abp/Framework/scripts/libs/abp.spin.js",

                        

                        "~/Abp/Framework/scripts/libs/angularjs/abp.ng.js",

                        "~/Content/JS/Main.js",
                        "~/Content/JS/app.js"
                    )
                );

            //APPLICATION RESOURCES

            //~/Bundles/css
            bundles.Add(
                new StyleBundle("~/Bundles/css")
                    .Include("~/css/main.css")
                );

            //~/Bundles/js
            bundles.Add(
                new ScriptBundle("~/Bundles/js")
                    .Include("~/js/main.js")
                );

            //~/Bundles/DataTable
            bundles.Add(
                new ScriptBundle("~/Bundles/DataTable")
                    .Include("~/Content/themes/Plugins/Datatable/jquery.dataTables.min.js")
                    .Include("~/Content/themes/Plugins/Datatable/jquery.dataTables.bootstrap.min.js")
                    .Include("~/Content/themes/Plugins/Datatable/dataTables.buttons.min.js")
                    .Include("~/Content/themes/Plugins/Datatable/buttons.flash.min.js")
                    .Include("~/Content/themes/Plugins/Datatable/jszip.min.js")
                    .Include("~/Content/themes/Plugins/Datatable/buttons.print.min.js")
                    .Include("~/Content/themes/Plugins/Datatable/pdfmake.min.js")
                    .Include("~/Content/themes/Plugins/Datatable/vfs_fonts.js")
                    .Include("~/Content/themes/Plugins/Datatable/buttons.colVis.min.js")
                );
        }
    }
}