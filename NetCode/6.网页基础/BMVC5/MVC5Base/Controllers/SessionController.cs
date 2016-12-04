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
            return View();
        }
    }
}