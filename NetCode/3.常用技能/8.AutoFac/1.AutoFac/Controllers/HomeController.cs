using _1.AutoFac.IBLL;
using System.Web.Mvc;

namespace _1.AutoFac.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ITestBLL testBLL = Container.Resolve<ITestBLL>();
            ViewBag.Name = testBLL.GetName();
            return View();
        }
    }
}