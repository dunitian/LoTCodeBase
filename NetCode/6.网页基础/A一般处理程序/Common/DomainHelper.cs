using System;
using System.Web;

namespace CSharpStudy.Common
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
                //eg:我们网站是a.com,那么*.a.com引用都可以正常显示 *.a.com/ASHX/GReferUrl.ashx
                //b.com引用我们的图片： <img src="http://a.com/ASHX/GReferUrl.ashx">
                return true;
            }
            return false;
        }
    }
}