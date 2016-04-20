using System.Web;

namespace CSharpStudy
{
    /// <summary>
    /// 01.初始一般处理程序
    /// </summary>
    public class AIndex : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write("Hello World");
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