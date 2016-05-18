using Microsoft.Owin;
using Owin;
using Microsoft.Owin.Cors;

[assembly: OwinStartup(typeof(OWIN_SignalR.Startup))]

namespace OWIN_SignalR
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCors(CorsOptions.AllowAll);
            Microsoft.AspNet.SignalR.GlobalHost.HubPipeline.AddModule(new OWIN_SignalR.Handler.ErrorHandler());//异常捕获
            app.MapSignalR();
        }
    }
}
