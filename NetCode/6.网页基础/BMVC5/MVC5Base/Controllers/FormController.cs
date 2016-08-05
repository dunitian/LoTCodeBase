using System.Web.Mvc;
using MVC5Base.Models;

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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(UserInfo model)
        {
            if (ModelState.IsValid)
            {
                if (model.Pass == "net1")
                {
                    return RedirectToAction("Manager", "Form");
                }
                else
                {
                    ModelState.AddModelError("", "密码错误");
                }
            }
            return View(model);// 如果出错，则重新显示表单
        }
    }
}