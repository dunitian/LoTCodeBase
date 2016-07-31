using MVC5Base.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MVC5Base.Controllers
{
    /// <summary>
    /// 视图演示
    /// </summary>
    public class IndexController : Controller
    {
        public ActionResult Index(string id)
        {
            ViewBag.ID = id;
            return View();
        }
        /// <summary>
        /// 4.共用其他视图（只是共用视图，并不走他的控制器，所以你必须给ViewBag.ID赋值，不然View就没有值了）
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult GoIndex(string id)
        {
            ViewBag.ID = "共用的是Index/Index下的视图，ID：" + id;
            //return View("Index"); 写法一
            return View("~/Views/Index/Index.cshtml");
        }
        /// <summary>
        /// 5.强类型视图
        /// </summary>
        /// <returns></returns>
        public ActionResult List()
        {
            var noteList = new List<NoteInfo>() { new NoteInfo { NTitle = "1" }, new NoteInfo { NTitle = "2" }, new NoteInfo { NTitle = "3" }, new NoteInfo { NTitle = "4" } };
            return View(noteList);
        }
        /// <summary>
        ///  6.Razor的简单接触
        /// </summary>
        /// <returns></returns>
        public ActionResult Razor()
        {
            ViewBag.Test = "<script>alert('xxx');</script>";
            return View();
        }
    }
}