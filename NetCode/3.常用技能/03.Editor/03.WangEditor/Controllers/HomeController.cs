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
            if (file.ContentLength > 10485760) { return Content("error|文件10M以内"); }
            //如果是上传文件，再添加其他格式即可
            string filterStr = ".gif,.jpg,.jpeg,.bmp,.png";
            string fileExt = Path.GetExtension(file.FileName).ToLower();
            if (!filterStr.Contains(fileExt)) { return Content("error|文件后缀不对"); }
            //防止黑客恶意绕过，从根本上判断下文件后缀
            if (!CheckingExt(file.InputStream))
            {
                return Content("error|文件后缀不对");
            }

            //todo: md5判断一下文件是否已经上传过,如果已经上传直接返回 return Content(缩略图地址#sqlPath);

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
            return Content(string.Format("{0}#{1}", sqlPath, sqlPath));//第一个sqlPath以后换成缩略图的地址
        }

        /*文件扩展名说明
             *4946/104116 txt
             *7173        gif 
             *255216      jpg
             *13780       png
             *6677        bmp
             *239187      aspx,asp,sql
             *208207      xls.doc.ppt
             *6063        xml
             *6033        htm,html
             *4742        js
             *8075        xlsx,zip,pptx,mmap,zip
             *8297        rar   
             *01          accdb,mdb
             *7790        exe,dll           
             *5666        psd 
             *255254      rdp 
             *10056       bt种子 
             *64101       bat 
             *4059        sgf
        */
        /// <summary>
        /// 判断扩展名是否是指定类型---默认是判断图片格式，符合返回true
        /// eg：file,"7173", "255216", "6677", "13780" //gif  //jpg  //bmp //png
        /// </summary>
        /// <param name="stream">文件流</param>
        /// <param name="fileTypes">文件扩展名</param>
        /// <returns></returns>
        private bool CheckingExt(Stream stream, params string[] fileTypes)
        {
            if (fileTypes.Length == 0) { fileTypes = new string[] { "7173", "255216", "6677", "13780" }; }
            bool result = false;
            string fileclass = "";
            //读取头两个字节
            using (stream)
            {
                using (var reader = new BinaryReader(stream))
                {
                    try
                    {
                        //读取每个文件的头两个字节
                        for (int i = 0; i < 2; i++)
                        {
                            byte buffer = reader.ReadByte();
                            fileclass += buffer.ToString();
                        }
                    }
                    catch { return false; }
                }
            }
            //校验
            for (int i = 0; i < fileTypes.Length; i++)
            {
                if (fileclass == fileTypes[i])
                {
                    result = true;
                    break;
                }
            }
            return result;
        }
    }
}