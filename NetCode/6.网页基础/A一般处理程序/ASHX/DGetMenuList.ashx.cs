using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Web;

namespace CSharpStudy
{
    /// <summary>
    /// 04.ADO.Net数据库操作
    /// </summary>
    public class DGetMenuList : IHttpHandler
    {
        private static string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
        public void ProcessRequest(HttpContext context)
        {
            string path = context.Request.MapPath("/MyHtmlPage.html");//不推荐使用context.server.MapPath
            string pageStr = System.IO.File.ReadAllText(path);
            var dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connStr)) { new SqlDataAdapter("select MName,MPrice,MType from View_DNTMenu", conn).Fill(dt); }
            if (dt.Rows.Count > 0 && dt.Columns.Count > 0)
            {
                pageStr = pageStr.Replace("@dnt", GetHTMLStr(dt)).Replace("@title", "ADO.Net数据库操作");
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