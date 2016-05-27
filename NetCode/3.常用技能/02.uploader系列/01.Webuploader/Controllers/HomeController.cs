using System;
using System.IO;
using System.Web;
using System.Web.Mvc;

namespace _01.Webuploader.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// 图片上传
        /// </summary>
        /// <returns></returns>
        public JsonResult Upload(HttpPostedFileBase file)
        {
            string filterStr = ".gif,.jpg,.jpeg,.bmp,.png";
            string fileExt = Path.GetExtension(file.FileName).ToLower();
            if (!filterStr.Contains(fileExt)) { return Json(new { status = false, msg = "图片格式不对" }); }
            if (file.ContentLength > 10485760) { return Json(new { status = false, msg = "文件10M以内" }); }

            string path = string.Format("{0}/{1}", "/lotFiles", DateTime.Now.ToString("yyyy-MM-dd"));
            string fileName = string.Format("{0}{1}", Guid.NewGuid().ToString("N"), fileExt);
            string sqlPath = string.Format("{0}{1}", path, fileName);
            string dirPath = Server.MapPath(path);

            if (!Directory.Exists(dirPath)) { Directory.CreateDirectory(dirPath); }
            try
            {
                file.SaveAs(Path.Combine(dirPath, fileName));
                //todo: 未来写存数据库的Code
            }
            catch { return Json(new { status = false, msg = "文件保存失败" }); }
            return Json(new { status = true });
        }
    }
}