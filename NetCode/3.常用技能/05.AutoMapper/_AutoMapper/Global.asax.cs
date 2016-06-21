using _AutoMapper.AutoMapper;
using System.Web.Mvc;
using System.Web.Routing;

namespace _AutoMapper
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            //AutoMapper注册
            AutoMapperConfig.Initialize();
        }
    }
}
