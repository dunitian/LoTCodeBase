using MVC5Base.Models;
using System.Web.Mvc;

namespace MVC5Base.Controllers
{
    public class SessionController : Controller
    {
        /// <summary>
        /// Session状态服务器
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            if (Session["user"] == null)
            {
                return RedirectToAction("Login", "Session");
            }
            return View();
        }
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
                //登录成功跳转到Index
                if (model.Name == "dnt" && model.Pass == "dnt")
                {
                    Session["user"] = "dnt";
                    return RedirectToAction("Index", "Session");
                }
                else
                {
                    ModelState.AddModelError("", "用户名或密码错误（用户名和密码都是dnt）");
                }
            }

            return View(model);//如果出错，则重新显示表单
        }
    }
}