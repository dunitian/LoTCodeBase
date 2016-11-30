using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Base.Controllers
{
    public class TestController : Controller
    {
        /// <summary>
        /// 缓存测试
        /// </summary>
        /// <returns></returns>
        [OutputCache(Duration = 1000)]
        public ActionResult A()
        {
            return View("~/Views/Test/Index.cshtml");
        }
        [OutputCache(Duration = 1000, VaryByParam = "id")]
        public ActionResult B(string id)
        {
            return View("~/Views/Test/Index.cshtml");
        }
        [OutputCache(Duration = 1000, VaryByParam = "id;name")]
        public ActionResult C(string id, string name)
        {
            return View("~/Views/Test/Index.cshtml");
        }
    }
}