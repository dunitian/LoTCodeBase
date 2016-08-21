using MVC5Base.Models;
using System.Web.Mvc;

namespace MVC5Base.Controllers
{
    public class ModelController : Controller
    {
        #region 10.过度提交
        /// <summary>
        /// 模型常用特性和过度提交防御
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            ViewBag.Product = new Product { ID = "SJ008-1012", Name = "小馒头", Count = 23, Price = 1.25 };
            return View();
        }
        /// <summary>
        /// 过度提交--偷偷的把价格改了
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult Put(Product model)
        {
            ViewBag.Product = model;
            return View("~/Views/Model/Index.cshtml");
        }
        /// <summary>
        /// 不允许修改某些字段
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult Update1([Bind(Exclude = "ID,Price")]Product model)
        {
            #region 默认值
            if (model.ID == null) model.ID = "SJ008-1012";
            if (model.Name == null) model.Name = "小馒头";
            if (model.Price == 0) model.Price = 1.25;
            #endregion

            ViewBag.Product = model;
            return View("~/Views/Model/Index.cshtml");
        }
        /// <summary>
        /// 只允许修改某些字段
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult Update([Bind(Include = "Count")]Product model)
        {
            #region 默认值
            if (model.ID == null) model.ID = "SJ008-1012";
            if (model.Name == null) model.Name = "小馒头";
            if (model.Price == 0) model.Price = 1.25;
            #endregion

            ViewBag.Product = model;
            return View("~/Views/Model/Index.cshtml");
        }
        #endregion

        #region 11.模型绑定
        /// <summary>
        /// 模型绑定
        /// </summary>
        /// <returns></returns>
        public ActionResult ModelBind()
        {
            return View();
        }
        public ActionResult BindModelA()
        {
            ViewBag.Name = Request["Name"];
            ViewBag.Pass = Request["Pass"];
            return View("~/Views/Model/BindModel.cshtml");
        }
        public ActionResult BindModelB(string Name, string Pass)
        {
            ViewBag.Name = Name;
            ViewBag.Pass = Pass;
            return View("~/Views/Model/BindModel.cshtml");
        }
        public ActionResult BindModelC(UserInfo model)
        {
            if (model != null)
            {
                ViewBag.Name = model.Name;
                ViewBag.Pass = model.Pass;
            }
            return View("~/Views/Model/BindModel.cshtml");
        }
        /// <summary>
        /// 手动绑定
        /// </summary>
        /// <returns></returns>
        public ActionResult BindModel()
        {
            var model = new UserInfo();
            if (TryUpdateModel(model))
            {
                if (model != null)
                {
                    ViewBag.Name = model.Name;
                    ViewBag.Pass = model.Pass;
                }
            }
            else
            {
                //绑定失败
            }
            return View("~/Views/Model/BindModel.cshtml");
        }
        #endregion

        #region 12.验证注解
        /// <summary>
        /// 12.验证注解
        /// </summary>
        /// <returns></returns>
        public ActionResult ValidateNote()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ValidateNote(Register model)
        {
            if (ModelState.IsValid)
            {

            }
            return View(model);
        }

        public JsonResult CheckName(string Name)
        {
            if (Name == "dnt")
            {
                return Json(false,JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(true,JsonRequestBehavior.AllowGet);
            }
        }
        public JsonResult CheckEmail(string Email)
        {
            if (Email == "dnt@dnt.com")
            {
                return Json(false);
            }
            else
            {
                return Json(true);
            }
        }
        #endregion
    }
}