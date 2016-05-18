using Microsoft.AspNet.SignalR;
using System;
using System.Threading.Tasks;

namespace OWIN_SignalR.Hubs
{
    public class DntHub : Hub
    {
        public void ServiceSend(string name, string message)
        {
            Clients.All.addMessage(name, message);
#if DEBUG
            throw new Exception("调试时自动抛出用来测试的错误信息:在DntHub类中");
#endif
        }
    }
}