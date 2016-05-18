using Microsoft.Owin.Hosting;
using System;

namespace OWIN.WebAPi_SignalR
{
    class Program
    {
        //参考：http://www.asp.net/web-api/overview/hosting-aspnet-web-api/use-owin-to-self-host-web-api
        static void Main(string[] args)
        {
            string url = "http://localhost:3845/";

            // 启动 OWIN Host
            using (WebApp.Start<Startup>(url))
            {
                Console.WriteLine("Server running on {0}", url);
                Console.ReadLine();                
            }
        }
    }
}
