using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using System.Web.Http;

[assembly: OwinStartup(typeof(OWIN.WebAPi_SignalR.Startup))]

namespace OWIN.WebAPi_SignalR
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //配置WebApi
            HttpConfiguration config = new HttpConfiguration();
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            app.UseWebApi(config);
        }
    }
}
