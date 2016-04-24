using System.IO;
using System.Web;

namespace CSharpStudy.ASHX
{
    /// <summary>
    /// Manager 的摘要说明
    /// </summary>
    public class Manager : IHttpHandler, System.Web.SessionState.IReadOnlySessionState//session
    {

        public void ProcessRequest(HttpContext context)
        {
            var cookie = context.Request.Cookies["user"];
            var session = context.Session["user"];
            if (cookie != null)
            {
                string htmlStr = File.ReadAllText(context.Request.MapPath("/LoginPage/manager.html"), System.Text.Encoding.UTF8).Replace("@content", string.Format("Cookie登录。用户名为：{0}", cookie.Value));
                context.Response.Write(htmlStr);
            }
            if (session != null)
            {
                string htmlStr = File.ReadAllText(context.Request.MapPath("/LoginPage/manager.html"), System.Text.Encoding.UTF8).Replace("@content", string.Format("Session登录。用户名为：{0}", session.ToString()));
                context.Response.Write(htmlStr);
            }
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