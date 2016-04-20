using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Web;

namespace CSharpStudy
{
    /// <summary>
    /// 05.Get,Post请求处理
    /// </summary>
    public class EGetTheMenuList : IHttpHandler
    {
        private static string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
        public void ProcessRequest(HttpContext context)
        {
            //var requestType = context.Request.HttpMethod.ToLower(); //请求类型 get，post 等
            string path = context.Request.MapPath("/MyHtmlPage.html");//不推荐使用context.server.MapPath
            string pageStr = System.IO.File.ReadAllText(path);
            var mTypeStr = context.Request["MType"];
            if (mTypeStr != null)
            {
                var dt = new DataTable();
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    var adapter = new SqlDataAdapter("select MName,MPrice,MType from View_DNTMenu where MType=@MType", conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@MType", mTypeStr.ToString());
                    adapter.Fill(dt);
                }
                if (dt.Rows.Count > 0 && dt.Columns.Count > 0)
                {
                    pageStr = pageStr.Replace("@dnt", GetHTMLStr(dt)).Replace("@title", "Get请求处理");
                }
            }
            context.Response.Write(pageStr);
            context.Response.End();
        }

        /// <summary>
        /// 拼接HTML
        /// </summary>
        /// <param name="pageStr"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        private static string GetHTMLStr(DataTable dt)
        {
            StringBuilder sb = new StringBuilder();
            foreach (DataRow item in dt.Rows)
            {
                sb.Append("<tr>");
                sb.Append("<td>");
                sb.Append(item["MName"]);
                sb.Append("</td>");
                sb.Append("<td>");
                sb.Append(item["MPrice"]);
                sb.Append("</td>");
                sb.Append("<td>");
                sb.Append(item["MType"]);
                sb.Append("</td>");
                sb.Append("</tr>");
            }
            return sb.ToString();
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