using System;
using System.Linq;
using Microsoft.AspNet.SignalR;
using OWIN_SignalR.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OWIN_SignalR.Hubs
{
    public class BaseHub : Hub
    {
        //存储当前在线用户(后期可以用数据库之类的存储)
        protected static IList<QQModel> qqModelList = new List<QQModel>();

        /// <summary>
        /// 当连接连接到此集线器实例时调用==QQ聊天这个案例暂时不需要使用这个方法
        /// </summary>
        /// <returns></returns>
        public override Task OnConnected()
        {
            #region 优化以前的代码
            ////用户上线
            //string connId = Context.ConnectionId;
            //var model = qqModelList.SingleOrDefault(q => q.QQConnectionId == connId);
            //if (model == null)
            //{
            //    qqModelList.Add(new QQModel() { QQConnectionId = connId });
            //} 
            #endregion
            #region 登录后可以使用
            //qqModelList.Add(new QQModel() { QQConnectionId = Context.ConnectionId, QQName = Context.User.Identity.Name });
            #endregion
            return base.OnConnected();
        }

        /// <summary>
        /// 重写连接的时候调用
        /// </summary>
        /// <returns></returns>
        public override Task OnReconnected()
        {
            return base.OnReconnected();
        }

        /// <summary>
        /// 断开的时候调用
        /// </summary>
        /// <param name="stopCalled"></param>
        /// <returns></returns>
        public override Task OnDisconnected(bool stopCalled)
        {
            //用户下线
            string connId = Context.ConnectionId;
            var model = qqModelList.SingleOrDefault(q => q.QQConnectionId == connId);
            if (model != null)
            {
                qqModelList.Remove(model);
            }
            return base.OnDisconnected(stopCalled);
        }
    }
}
