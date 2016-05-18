using OWIN_SignalR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OWIN_SignalR.Hubs
{
    public class QQHub : BaseHub
    {
        /// <summary>
        /// 自定义上线
        /// </summary>
        /// <param name="name"></param>
        public void Online(string name)
        {
            if (string.IsNullOrEmpty(name)) { return; }
            name = Uri.EscapeDataString(name);//编码一下
            string connId = Context.ConnectionId;
            var model = qqModelList.SingleOrDefault(q => q.QQConnectionId == connId);
            if (model == null)
            {
                qqModelList.Add(new QQModel() { QQConnectionId = connId, QQName = name });
            }
        }

        /// <summary>
        /// 给某个用户发消息
        /// </summary>
        /// <param name="name"></param>
        /// <param name="msg"></param>
        public void ServiceSend(string name, string msg)
        {
            if (string.IsNullOrEmpty(name)) { return; }
            name = Uri.EscapeDataString(name);
            string clientConnId = Context.ConnectionId;
            var model = qqModelList.SingleOrDefault(q => q.QQName == name);
            if (model != null)
            {
                Clients.Client(model.QQConnectionId).SendMsg(msg);
            }
        }
    }
}
