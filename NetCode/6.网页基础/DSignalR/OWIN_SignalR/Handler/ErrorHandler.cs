using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OWIN_SignalR.Handler
{
    public class ErrorHandler : HubPipelineModule
    {
        //参考：http://www.asp.net/signalr/overview/guide-to-the-api/hubs-api-guide-server#singleusergroups
        protected override void OnIncomingError(ExceptionContext ex, IHubIncomingInvokerContext invokerContext)
        {
            string connectionId = invokerContext.Hub.Context.ConnectionId;
            invokerContext.Hub.Clients.Caller.ShowError(string.Format("ConnectionId:{0},ErrorMessage:{1}", connectionId, ex.Error.Message));
        }
    }
}
