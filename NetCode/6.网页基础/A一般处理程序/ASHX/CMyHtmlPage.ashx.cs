using System.Web;

namespace CSharpStudy
{
    /// <summary>
    /// 03.DIV 静态模板使用
    /// </summary>
    public class CMyHtmlPage : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            string path = context.Request.MapPath("/MyHtmlPage.html");//不推荐使用context.server.MapPath
            string pageStr = System.IO.File.ReadAllText(path);
            pageStr = pageStr.Replace("@dnt", "<tr><td>mmd</td><td>2.11</td><td>未知</td></tr>").Replace("@title", "静态模板使用");
            context.Response.Write(pageStr);
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