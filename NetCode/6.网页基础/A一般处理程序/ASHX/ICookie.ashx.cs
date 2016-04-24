using System;
using System.IO;
using System.Web;

namespace CSharpStudy.ASHX
{
    /// <summary>
    /// ICookie 的摘要说明
    /// </summary>
    public class ICookie : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string methodType = context.Request.HttpMethod.ToLower();
            //get 请求
            if (methodType == "get")
            {
                string htmlStr = File.ReadAllText(context.Request.MapPath("/LoginPage/login.html"), System.Text.Encoding.UTF8).Replace("@title", "Cookie专用").Replace("@path", "/ASHX/ICookie.ashx");
                context.Response.Write(htmlStr);
            }
            else if (methodType == "post")
            {
                var obj = context.Request["name"];
                if (obj != null && !obj.Equals(string.Empty))
                {
                    HttpCookie cookie = new HttpCookie("user", obj.ToString());
                    cookie.Path = "/ASHX/"; //有效范围
                    cookie.Expires = DateTime.Now.AddDays(1); //过期时间
                    //cookie.Domain = "dnt.dkill.net";//有效域名为二级+二级下的三级 [顶级域名：dkill.net 二级域名：dnt.dkill.net 三级域名：dnt.mmd.dkill.net]
                    //别忘记添加这一句
                    context.Response.Cookies.Add(cookie);//方法一
                    //context.Response.SetCookie(cookie);//方法二
                    context.Response.Redirect("/ASHX/Manager.ashx");
                }
                context.Response.Write("<script>alert('未登录，请重新登陆！');window.location.href='/ASHX/ICookie.ashx';</script>");
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