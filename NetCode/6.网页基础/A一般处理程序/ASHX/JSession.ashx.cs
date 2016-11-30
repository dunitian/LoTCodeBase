using System.IO;
using System.Web;
using System.Web.SessionState;

namespace CSharpStudy.ASHX
{
    /// <summary>
    /// JSession 的摘要说明
    /// </summary>
    public class JSession : IHttpHandler, IRequiresSessionState //想用session就必须实现IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            string methodType = context.Request.HttpMethod.ToLower();
            //get 请求
            if (methodType == "get")
            {
                string htmlStr = File.ReadAllText(context.Request.MapPath("/LoginPage/login.html"), System.Text.Encoding.UTF8).Replace("@title", "Session专用").Replace("@path", "/ASHX/JSession.ashx");
                context.Response.Write(htmlStr);
            }
            else if (methodType == "post")
            {
                var obj = context.Request["name"];
                if (!string.IsNullOrWhiteSpace(obj))
                {
                    context.Session["user"] = obj;
                    //context.Session.Add("user", obj.ToString());
                    context.Response.Redirect("/ASHX/Manager.ashx");
                }
                context.Response.Write("<script>alert('未登录，请重新登陆！');window.location.href='/ASHX/JSession.ashx';</script>");
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