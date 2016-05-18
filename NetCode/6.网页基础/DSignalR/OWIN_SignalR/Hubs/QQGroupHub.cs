using System;
using Microsoft.AspNet.SignalR;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;

namespace OWIN_SignalR.Hubs
{
    /// <summary>
    /// 直接利用组的概念来群聊或者单聊
    /// </summary>
    public class QQGroupHub : Hub
    {
        /// <summary>
        /// 存放ConnectionId和GroupName
        /// </summary>
        public static IDictionary<string, string> dics = new Dictionary<string, string>();

        /// <summary>
        /// 加入组
        /// </summary>
        /// <param name="groupName"></param>
        /// <returns></returns>
        public async Task JoinGroup(string groupName)
        {
            if (!dics.ContainsKey(Context.ConnectionId))
            {
                await Groups.Add(Context.ConnectionId, groupName);
                dics.Add(Context.ConnectionId, groupName);//组添加成功后才能添加
            }
        }

        /// <summary>
        /// 发消息
        /// </summary>
        /// <returns></returns>
        public void GroupSend(string groupName, string msg)
        {
            Clients.Group(groupName).SendMsg(msg);
        }

        /// <summary>
        /// 断开的时候
        /// </summary>
        /// <param name="stopCalled"></param>
        /// <returns></returns>
        public override Task OnDisconnected(bool stopCalled)
        {
            if (dics.ContainsKey(Context.ConnectionId))
            {
                string groupName = dics[Context.ConnectionId];
                Groups.Remove(Context.ConnectionId, groupName);
                dics.Remove(Context.ConnectionId);//组移除完后才能移除
            }
            return base.OnDisconnected(stopCalled);
        }
    }
}
