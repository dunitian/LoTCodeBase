using System;
using System.Web;

namespace LoTLibrary
{
    public class DomainHelper
    {
        /// <summary>
        /// 验证是否是其他域名（ture则非本域名）
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public static bool IsOtherDomain(HttpContext context)
        {
            var urlReferrer = context.Request.UrlReferrer;//注意一下可能为空(直接访问一般处理程序就是null)
            //非本域名
            if (urlReferrer != null && Uri.Compare(urlReferrer, context.Request.Url, UriComponents.HostAndPort, UriFormat.SafeUnescaped, StringComparison.CurrentCulture) != 0)
            {
                context.Response.Write(string.Format("来源地址({0})非本站，不给予显示！", urlReferrer));
                return true;
            }
            return false;
        }
    }
}