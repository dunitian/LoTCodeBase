using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MVC5Base
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            //BudnleConfig
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
