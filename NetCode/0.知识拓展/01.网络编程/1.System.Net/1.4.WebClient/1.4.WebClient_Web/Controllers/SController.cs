using System;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace _1._4.WebClient_Web.Controllers
{
    public class SController : Controller
    {
        public async Task<ActionResult> Index(string wd, string pn)
        {
            var client = new WebClient();
            client.Encoding = Encoding.UTF8;
            ViewBag.HTMLStr = await client.DownloadStringTaskAsync(new Uri(string.Format("http://www.baidu.com/s?wd={0}&pn={1}", wd, pn)));
            return View();
        }
    }
}