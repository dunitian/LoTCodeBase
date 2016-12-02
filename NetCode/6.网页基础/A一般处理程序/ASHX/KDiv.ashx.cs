using System.Web;

namespace CSharpStudy.ASHX
{
    /// <summary>
    /// 所有的*.jsp的请求全部交给这个处理程序处理了
    /// </summary>
    public class KDiv : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            //System.Uri 类型。完整的 URL  http://localhost:19423/ASHX/KDiv.ashx?dd=mmd
            //如果我们把它当作字符串一样直接输出，它就相当于 Request.Url.AbsoluteUri。
            string url = context.Request.Url.ToString();

            //从 URL 根路径开始计算的字符串，包含查询字符串。/ASHX/KDiv.ashx?dd=mmd
            string rawUrl = context.Request.RawUrl;

            //获取当前请求的虚拟路径。/ASHX/KDiv.ashx
            string pathUrl = context.Request.Path;

            //System.Uri 类型。来源页面完整的 URL。http://localhost:19423/index.html?dd=mmd
            string refUrl = string.Concat(context.Request.UrlReferrer);

            context.Response.Write($"Url:{url}<br /><br />");
            context.Response.Write($"RawUrl:{rawUrl}<br /><br />");
            context.Response.Write($"Path:{pathUrl}<br /><br />");
            context.Response.Write($"UrlReferrer:{refUrl}<br /><br />");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}