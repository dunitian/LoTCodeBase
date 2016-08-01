using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MVC5Base.Controllers
{
    public class LayController : Controller
    {
        /// <summary>
        /// 大首页
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 分部视图
        /// </summary>
        /// <returns></returns>
        public PartialViewResult Part()
        {
            ViewBag.Test = "啦啦啦";
            return PartialView();
        }
        /// <summary>
        /// 分部视图--异步演示
        /// </summary>
        /// <returns></returns>
        public async Task<PartialViewResult> PartAsync()
        {
            try
            {
                await GetNumAsync();
            }
            catch { }
            ViewBag.Test = "我是卖报的";
            return PartialView();
        }
        /// <summary>
        /// 写个异步的简单案例
        /// </summary>
        /// <param name="connStr"></param>
        /// <param name="sql"></param>
        /// <param name="commandType"></param>
        /// <param name="pms"></param>
        /// <returns></returns>
        private async Task<int> GetNumAsync(string connStr = "", string sql = "", CommandType commandType = CommandType.Text, SqlParameter[] pms = null)
        {
            using (var conn = new SqlConnection(connStr))
            {
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = commandType;
                    if (pms != null && pms.Length > 0)
                    {
                        cmd.Parameters.AddRange(pms);
                    }
                    await conn.OpenAsync();
                    int i = await cmd.ExecuteNonQueryAsync();
                    cmd.Parameters.Clear();
                    return i;
                }
            }
        }
    }
}