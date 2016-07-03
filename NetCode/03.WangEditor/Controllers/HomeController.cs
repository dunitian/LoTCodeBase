using System;
using System.IO;
using System.Web;
using System.Web.Mvc;

namespace _03.WangEditor.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 图片上传
        /// </summary>
        /// <returns></returns>
        public ContentResult Upload(HttpPostedFileBase file)
        {
            if (file == null) { return Content("error|文件不能为空"); }
            string filterStr = ".gif,.jpg,.jpeg,.bmp,.png";
            //如果是上传文件，再添加其他格式即可
            string fileExt = Path.GetExtension(file.FileName).ToLower();
            if (!filterStr.Contains(fileExt)) { return Content("error|文件后缀不对"); }
            if (file.ContentLength > 10485760) { return Content("error|文件10M以内"); }

            //todo: md5判断一下文件是否已经上传过,如果已经上传直接返回 return Content(sqlPath#缩略图地址);

            string path = string.Format("{0}/{1}", "/lotFiles", DateTime.Now.ToString("yyyy-MM-dd"));
            string fileName = string.Format("{0}{1}", Guid.NewGuid().ToString("N"), fileExt);
            string sqlPath = string.Format("{0}/{1}", path, fileName);
            string dirPath = Request.MapPath(path);

            if (!Directory.Exists(dirPath)) { Directory.CreateDirectory(dirPath); }
            try
            {
                //todo：未来写缩略图的代码

                file.SaveAs(Path.Combine(dirPath, fileName));
                //todo: 未来写存数据库的Code
            }
            catch { return Content("error|文件保存失败"); }
            return Content(string.Format("{0}#{1}", sqlPath, "缩略图地址"));
        }
    }
}