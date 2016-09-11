using System;
using System.IO;
using ImageMagick;
using System.Web.Mvc;
using System.Diagnostics;
using System.Drawing;

namespace _09.WatermarkDemo.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// 按指定位置水印
        /// </summary>
        /// <param name="imgPath"></param>
        /// <param name="waterImgPath"></param>
        /// <returns></returns>
        public ActionResult Index(string imgPath = @"M:/水印/1.jpg", string waterImgPath = @"M:/水印/水印图/黑色.png")
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();

            string fileExt = Path.GetExtension(imgPath).ToLower();

            string path = string.Format("{0}/{1}", "/lotFiles", DateTime.Now.ToString("yyyy-MM-dd"));
            string fileName = string.Format("{0}{1}", Guid.NewGuid().ToString("N"), fileExt);
            string sqlPath = string.Format("{0}/{1}", path, fileName);
            string dirPath = Request.MapPath(path);
            if (!Directory.Exists(dirPath)) { Directory.CreateDirectory(dirPath); }

            using (var image = new MagickImage(imgPath))
            {
                using (var watermark = new MagickImage(waterImgPath))
                {
                    //水印（按照方向水印）
                    //image.Composite(watermark, Gravity.Northwest, CompositeOperator.Over);
                    //透明度
                    watermark.Evaluate(Channels.Alpha, EvaluateOperator.Divide, 2);
                    //水印（按照位置水印）
                    image.Composite(watermark, 0, 0, CompositeOperator.Over);
                }
                image.Write(Path.Combine(dirPath, fileName));
            }

            timer.Stop();
            ViewBag.Img = sqlPath;
            ViewBag.Time = timer.ElapsedMilliseconds;

            return View();
        }
        /// <summary>
        /// 满屏水印
        /// </summary>
        /// <param name="imgPath"></param>
        /// <param name="waterImgPath"></param>
        /// <returns></returns>
        public ActionResult New(string imgPath = @"M:/水印/3.jpg", string waterImgPath = @"M:/水印/水印图/黑色.png")
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();

            string fileExt = Path.GetExtension(imgPath).ToLower();

            string path = string.Format("{0}/{1}", "/lotFiles", DateTime.Now.ToString("yyyy-MM-dd"));
            string fileName = string.Format("{0}{1}", Guid.NewGuid().ToString("N"), fileExt);
            string sqlPath = string.Format("{0}/{1}", path, fileName);
            string dirPath = Request.MapPath(path);
            if (!Directory.Exists(dirPath)) { Directory.CreateDirectory(dirPath); }

            try
            {
                //原图
                using (var image = new MagickImage(imgPath))
                {
                    int imgWidth = image.Width;
                    int imgHeight = image.Height;

                    //单个水印图
                    using (var waterimg = new MagickImage(waterImgPath))
                    {
                        int smallWidth = waterimg.Width;
                        int smallHeight = waterimg.Height;

                        int x = Convert.ToInt32(Math.Ceiling(imgWidth * 1.0 / smallWidth));
                        int y = Convert.ToInt32(Math.Ceiling(imgHeight * 1.0 / smallHeight));

                        //透明度
                        waterimg.Evaluate(Channels.Alpha, EvaluateOperator.Divide, 2);
                        for (int i = 0; i < x; i++)
                        {
                            for (int j = 0; j < y; j++)
                            {
                                image.Composite(waterimg, i * smallWidth, j * smallHeight, CompositeOperator.Over);//水印
                            }
                        }
                    }
                    image.Write(Path.Combine(dirPath, fileName));
                }
            }
            catch (Exception ex)
            {
                ViewBag.Msg = ex.ToString();
            }

            timer.Stop();
            ViewBag.Img = sqlPath;
            ViewBag.Time = timer.ElapsedMilliseconds;

            return View("~/Views/Home/Index.cshtml");
        }
    }
}