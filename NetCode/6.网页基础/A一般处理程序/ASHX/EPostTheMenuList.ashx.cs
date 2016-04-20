using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Web;

namespace CSharpStudy
{
    /// <summary>
    /// 05.Get,Post请求处理
    /// </summary>
    public class EPostTheMenuList : IHttpHandler
    {
        private static string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
        public void ProcessRequest(HttpContext context)
        {
            //var requestType = context.Request.HttpMethod.ToLower(); //请求类型 get，post 等
            string htmlStr = string.Empty;
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
                    htmlStr = GetDataStr(dt);
                }
            }
            context.Response.Write(htmlStr);
            context.Response.End();//aspx页面进行post请求的时候，aspx.cs内部在处理post请求后可以加上类似的一句，可以避免很多错误
        }

        /// <summary>
        /// 拼接Json
        /// </summary>
        /// <param name="pageStr"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        private static string GetDataStr(DataTable dt)
        {
            StringBuilder sb = new StringBuilder("[");
            foreach (DataRow item in dt.Rows)
            {
                sb.Append("{");
                sb.Append("\"MName\":\"");
                sb.Append(item["MName"]);
                sb.Append("\",");
                sb.Append("\"MPrice\":\"");
                sb.Append(item["MPrice"]);
                sb.Append("\",");
                sb.Append("\"MType\":\"");
                sb.Append(item["MType"]);
                sb.Append("\"},");
            }
            sb.Remove(sb.Length-1, 1);
            sb.Append("]");
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