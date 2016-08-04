using System.Web.Mvc;

namespace MVC5Base.Controllers
{
    public class FormController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 8.0模拟登录~爆破演示
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        public JsonResult LoginOn(string name, string pass)
        {
            if (pass != "net1")
            {
                return Json(new { Status = false, Msg = "密码输入错误" });
            }
            return Json(new { Status = true, Msg = "登录成功" });
        }
        /// <summary>
        /// 模拟后台管理页面
        /// </summary>
        /// <returns></returns>
        public ActionResult Manager()
        {
            return View();
        }
        /// <summary>
        /// 8.1登录演示
        /// </summary>
        /// <returns></returns>
        public ActionResult Login()
        {
            return View();
        }
    }
}