using System.Web;

namespace CSharpStudy
{
    /// <summary>
    /// 02.向页面写HTML代码
    /// </summary>
    public class BWriteHTML : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            //context.Response.ContentType = "text/html";//这句不写也可以（默认就是html）
            context.Response.Write("<script>alert('dnt');</script>");
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