using System.Web;
using System.Web.Mvc;

namespace _02.KindEditor
{
    /// <summary>
    /// 记得引用 LitJSON.dll （packages包里面）
    /// </summary>
    public class HomeController : Controller
    {
        public static string saveTxt = "";//这里就不用数据库演示了，直接用这个字段存用户输入的内容，然后在Show页中显示出来

        /// <summary>
        /// kindeditor编辑器使用
        /// 你可以参考这个网站：http://kindeditor.net/demo.php
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 插入操作
        /// </summary>
        /// <param name="editorTxt"></param>
        /// <returns></returns>
        public ContentResult Add(string editorTxt)
        {
            //传过来的已经url编码了【带敏感字符的url服务器默认是拒绝请求的】
            editorTxt = HttpUtility.UrlDecode(editorTxt);//没有url编码的，解码还是他本身

            if (string.IsNullOrEmpty(editorTxt))
            {
                return Content("操作失败，编辑器真TM is shit！");
            }
            //必须保证存在数据库里面的文字是安全的
            saveTxt = HttpUtility.HtmlEncode(editorTxt);//假设是存到数据库里面【编码】
            return Content("ok");
        }

        /// <summary>
        /// 显示页面
        /// </summary>
        /// <returns></returns>
        public ActionResult Show()
        {
            ViewBag.editorTxt = HttpUtility.HtmlDecode(saveTxt);//模拟读取数据库【解码】
            return View();
        }
    }
}