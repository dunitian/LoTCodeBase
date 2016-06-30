using System;
using System.IO;
using System.Web;
using System.Web.Mvc;

namespace _02.LoTUploader.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// 图片上传
        /// </summary>
        /// <returns></returns>
        public JsonResult Upload(HttpPostedFileBase file)
        {
            if (file == null) { return Json(new { status = false, msg = "图片提交失败" }); }
            string filterStr = ".gif,.jpg,.jpeg,.bmp,.png";
            string fileExt = Path.GetExtension(file.FileName).ToLower();
            if (!filterStr.Contains(fileExt)) { return Json(new { status = false, msg = "图片格式不对" }); }
            if (file.ContentLength > 10485760) { return Json(new { status = false, msg = "文件10M以内" }); }

            //todo: md5判断一下文件是否已经上传过,如果已经上传直接返回 return Json(new { status = true, msg = sqlPath });

            string path = string.Format("{0}/{1}", "/lotFiles", DateTime.Now.ToString("yyyy-MM-dd"));
            string fileName = string.Format("{0}{1}", Guid.NewGuid().ToString("N"), fileExt);
            string sqlPath = string.Format("{0}{1}", path, fileName);
            string dirPath = Request.MapPath(path);

            if (!Directory.Exists(dirPath)) { Directory.CreateDirectory(dirPath); }
            try
            {
                file.SaveAs(Path.Combine(dirPath, fileName));
                //todo: 未来写存数据库的Code
            }
            catch { return Json(new { status = false, msg = "图片保存失败" }); }
            return Json(new { status = true, msg = sqlPath });
        }
    }
}