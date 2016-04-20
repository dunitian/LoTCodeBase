using System.Web;

namespace CSharpStudy.ASHX
{
    /// <summary>
    /// 06.页面跳转Redirect
    /// </summary>
    public class FRedirect : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.Redirect("/");
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