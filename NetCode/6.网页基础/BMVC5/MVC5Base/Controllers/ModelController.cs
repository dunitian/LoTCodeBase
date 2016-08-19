using MVC5Base.Models;
using System.Web.Mvc;

namespace MVC5Base.Controllers
{
    public class ModelController : Controller
    {
        /// <summary>
        /// 模型常用特性和过度提交防御
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            ViewBag.Product = new Product {ID="SJ008-1012", Name = "小馒头", Count = 23, Price = 1.25 };
            return View();
        }
        /// <summary>
        /// 偷偷的把价格改了
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult Put(Product model)
        {
            ViewBag.Product = model;
            return View("~/Views/Model/Index.cshtml");
        }
    }
}