using System.Web.Optimization;

namespace DemoMVC
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {


            //Bootstrap Script JS
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/Bootstrasp/bootstrap.js"));
            //jQuery Script JS
            bundles.Add(new ScriptBundle("~/bundles/jQuery").Include(
                      "~/Scripts/jQuery/jquery-3.4.1.js"));
            //Modernizer Script JS
            bundles.Add(new ScriptBundle("~/bundles/Modernizer").Include(
                      "~/Scripts/Modernizer/modernizr-2.8.3.js"));

            //CreateNewAccount JS
            bundles.Add(new ScriptBundle("~/bundles/JS/CreateNewAccount").Include(
                      "~/Scripts/CreateNewAccount/CreateNewAccount.js"));
            //UserRecord JS
            bundles.Add(new ScriptBundle("~/bundles/JS/UserRecord").Include(
                      "~/Scripts/UserRecord/UserRecord.js",
                      "~/Scripts/UserRecord/ManagePager.js"
                      ));

            bundles.Add(new ScriptBundle("~/bundles/chart").Include(
                      "~/Scripts/fusioncharts.js",
                      "~/Scripts/fusioncharts.charts.js",
                      "~/Scripts/Theme/fusioncharts.theme.ocean.js",
                      "~/Scripts/chart.js"
                      ));

            bundles.Add(new StyleBundle("~/Content/CSS").Include(
                      "~/Content/Bootstrap/bootstrap.css",
                      "~/Content/Site/Site.css"));
            //CreateNewAccount CSS
            bundles.Add(new StyleBundle("~/bundles/CSS/CreateNewAccount").Include(
                "~/Content/CreateNewAccount/CreateNewAccount.css"
                ));



        }
    }
}
