using System;
using System.IO;
using System.Web;
using System.Web.Mvc;

namespace _01.Webuploader.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// 文件上传
        /// </summary>
        /// <returns></returns>
        public JsonResult Upload(HttpPostedFileBase file)
        {
            //string filterStr = "gif,jpg,jpeg,bmp,png";
            string filterStr = ".gif,.jpg,.jpeg,.bmp,.png";
            string fileExt = Path.GetExtension(file.FileName).ToLower();
            if (!filterStr.Contains(fileExt)) { return Json("图片格式不对"); }
            if (file.ContentLength > 10485760) { return Json("单个文件必须10M以内"); }

            string path = string.Format("{0}/{1}", "/lotFiles", DateTime.Now.ToString("yyyy-MM-dd"));
            string fileName = string.Format("{0}{1}", Guid.NewGuid().ToString("N"), fileExt);
            string sqlPath = string.Format("{0}{1}", path, fileName);
            string dirPath = Server.MapPath(path);

            if (!Directory.Exists(dirPath))
            {
                Directory.CreateDirectory(dirPath);
            }
            try
            {
                file.SaveAs(Path.Combine(dirPath, fileName));
                //todo: 未来写存数据库的Code
            }
            catch
            {
                return Json("保存失败请重试");
            }
            return Json(sqlPath);
        }

        public ActionResult Uploader(string id, string name, string type, string lastModifiedDate, int size, HttpPostedFileBase file)
        {
            //../
            return View();
        }
    }
}