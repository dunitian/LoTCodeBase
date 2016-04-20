using System.Web;

namespace CSharpStudy
{
    /// <summary>
    /// 08.获取浏览器IP地址
    /// </summary>
    public class HIpAddress : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string ipStr = context.Request.UserHostAddress;
            context.Response.Write(ipStr);
            context.Response.End();
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