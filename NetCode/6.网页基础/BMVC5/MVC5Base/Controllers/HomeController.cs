using System.Web.Mvc;

namespace MVC5Base.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// 1.显示模式演示，请在PC打开和移动端打开看效果
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 2.合并（捆绑）脚本引用并压缩
        /// </summary>
        /// <returns></returns>
        public ActionResult Bundle()
        {
            return View();
        }
        /// <summary>
        /// 3.默认参数约定
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Action(string id)
        {
            ViewBag.ID = id;
            return View();
        }
    }
}