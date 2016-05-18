using Microsoft.Owin.Hosting;
using System;

namespace OWIN_SignalR
{
    class Program
    {
        //参考：http://www.asp.net/signalr/overview/deployment/tutorial-signalr-self-host
        //注意：如果执行失败，除了发生System.Reflection.TargetInvocationException 错误，你需要以管理员权限重新运行VS        
        static void Main(string[] args)
        {
            // 这将 *ONLY* 绑定到 localhost，如果你想要绑定到的所有地址。使用 http://*:8080 去绑定所以地址
            // 更多： http://msdn.microsoft.com/en-us/library/system.net.httplistener.aspx 

            //端口不固定，只要这个端口没用被使用就行
            string url = "http://localhost:5438";
            // 启动 OWIN Host
            using (WebApp.Start(url))
            {
                Console.WriteLine("Server running on {0}", url);
                Console.ReadLine();
            }
        }
    }
}