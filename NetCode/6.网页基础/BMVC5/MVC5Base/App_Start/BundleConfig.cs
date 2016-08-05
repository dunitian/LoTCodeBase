using System.Web.Optimization;

namespace MVC5Base
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/JS/BaseJs").Include("~/Scripts/jquery-{version}.js", "~/Scripts/bootstrap/bootstrap.js"));

            bundles.Add(new StyleBundle("~/CSS/BaseCss").Include("~/Scripts/bootstrap/bootstrap.css", "~/assets/css/site.css"));

            bundles.Add(new ScriptBundle("~/JS/Select").Include("~/Scripts/bootstrap-select/bootstrap-select.min.js", "~/Scripts/bootstrap-select/defaults-zh_CN.min.js"));

            bundles.Add(new StyleBundle("~/CSS/Select").Include("~/Scripts/bootstrap-select/bootstrap-select.min.css"));

            bundles.Add(new ScriptBundle("~/JS/JQVal").Include("~/Scripts/jquery.validate*"));
        }
    }
}