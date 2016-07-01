using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._5.WebRequest_WebResponse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region 获取Url地址
        /// <summary>
        /// 获取Url地址
        /// </summary>
        /// <returns></returns>
        private string GetUrl()
        {
            string urlStr = txtUrl.Text;
            if (string.IsNullOrWhiteSpace(urlStr))
            {
                MessageBox.Show("请输入网站地址！");
                return string.Empty;
            }
            if (!urlStr.StartsWith("http", StringComparison.InvariantCultureIgnoreCase))
            {
                urlStr = "http://" + urlStr;
            }
            return urlStr;
        }
        #endregion
        private void btn1_Click(object sender, System.EventArgs e)
        {
            Task.Run(GoGoGo);
        }

        private async Task GoGoGo()
        {
            var webRequest = WebRequest.Create(GetUrl());
            //获取或设置用于对 Internet 资源请求进行身份验证的网络凭据
            webRequest.Credentials = CredentialCache.DefaultNetworkCredentials;
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("该请求的协议方法：{0}\n", webRequest.Method);
            sb.AppendFormat("访问Internet的网络代理：{0}\n", webRequest.Proxy);
            sb.AppendFormat("请求数据的内容长度：{0}\n", webRequest.ContentLength);
            sb.AppendFormat("与该请求关联的URI：{0}\n", webRequest.RequestUri);
            sb.AppendFormat("获取或设置请求超时之前的时间（毫秒）：{0}\n", webRequest.Timeout);

            //客户端不应该创建Response，而是通过WebRequest的GetResponse方法进行创建
            var webResponse = await webRequest.GetResponseAsync();

            sb.AppendFormat("响应请求的URI：{0}\n", webResponse.ResponseUri);

            //获取返回数据流
            using (var stream = webResponse.GetResponseStream())
            {
                using (var reader = new StreamReader(stream))
                {
                    sb.AppendLine(await reader.ReadToEndAsync());
                }
            }
            rtxt1.Text = sb.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }
    }
}
