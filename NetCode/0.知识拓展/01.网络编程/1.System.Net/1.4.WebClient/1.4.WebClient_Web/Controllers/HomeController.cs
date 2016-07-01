using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace _1._4.WebClient_Web.Controllers
{
    //WebClient的常用属性和方法

    //  属性：
    //      BaseAddress     ：获取或设置 WebClient 发出请求的基 URI
    //      Encoding        ：获取和设置用于上载和下载字符串的Encoding
    //      Headers         ：获取或设置与请求关联的标头名称/值对集合
    //      QueryString     ：获取或设置与请求关联的查询名称/值对集合
    //      ResponseHeaders ：获取与响应关联的标头名称/值对集合

    //  方法：
    //      OpenRead        ：从指定资源处打开一个可读的流
    //      OpenWrite       ：打开一个流以将数据写入指定的资源

    //      DownloadData    ：以 Byte[] 形式下载请求的资源
    //      DownloadFile    ：将请求的URI资源下载到本地文件
    //      DownloadString  ：以 String 形式下载请求的资源

    //      UploadData       ：将数据缓冲区上传到指定的资源
    //      UploadFile       ：将指定的本地文件上传到指定的资源
    //      UploadValues     ：将指定的名称/值集合上传到指定的资源
    //      UploadString     ：使用 POST 方法将指定的字符串上传到指定的资源


    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            var client = new WebClient();
            client.Encoding = Encoding.UTF8;
            string htmlStr = await client.DownloadStringTaskAsync(new Uri("http://www.baidu.com"));
            ViewBag.HTMLStr = htmlStr;
            return View();
        }

        public async Task<ActionResult> FileDown(Uri uri, string fileName)
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();

            string filePath = Request.MapPath("/Temp/");
            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }
            var client = new WebClient();
            client.Encoding = Encoding.UTF8;
            await client.DownloadFileTaskAsync(uri, filePath + fileName);

            watch.Stop();
            ViewBag.Time = watch.ElapsedTicks;
            return View();
        }
    }
}