using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OWIN_SignalR.Models
{
    public class QQModel
    {
        /// <summary>
        /// ConnectionId
        /// </summary>
        public string QQConnectionId { get; set; }
        /// <summary>
        /// 用户昵称
        /// </summary>
        public string QQName { get; set; }
        /// <summary>
        /// QQ组名称
        /// </summary>
        public string QQGroupName { get; set; }
        /// <summary>
        /// 其他数据
        /// </summary>
        public dynamic OtherData { get; set; }
    }
}
