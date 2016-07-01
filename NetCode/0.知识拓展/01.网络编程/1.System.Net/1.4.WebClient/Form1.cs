using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace _1._4.WebClient
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

        #region 实例化WebClient对象
        /// <summary>
        /// 实例化WebClient对象
        /// </summary>
        /// <param name="url">Base Url</param>
        /// <returns></returns>
        private System.Net.WebClient GetWebClient(string url)
        {
            var client = new System.Net.WebClient();
            client.BaseAddress = url;                                               //设置WebClient基URL
            client.Encoding = Encoding.UTF8;                                        //下载字符串的编码格式
            client.Headers.Add("Content-Type", "aplication/x-www-form-urlencoded"); //为WebClient添加报头
            return client;
        }
        #endregion

        #region 获取文本内容
        /// <summary>
        /// 获取HTMLStr-方法1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn1_Click(object sender, EventArgs e)
        {
            string urlStr = GetUrl();
            var client = GetWebClient(urlStr);
            client.DownloadStringAsync(new Uri(urlStr));
            client.DownloadStringCompleted += Client_DownloadStringCompleted;
        }
        private void Client_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            txt1.Text = e.Result;
        }

        /// <summary>
        /// 获取HTMLStr-方法2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn2_Click(object sender, EventArgs e)
        {
            string urlStr = GetUrl();
            var client = GetWebClient(urlStr);
            client.OpenReadAsync(new Uri(urlStr));
            client.OpenReadCompleted += Client_OpenReadCompleted;
        }
        private async void Client_OpenReadCompleted(object sender, OpenReadCompletedEventArgs e)
        {
            using (var stream = e.Result)
            {
                using (var reader = new StreamReader(stream))
                {
                    txt1.Text = string.Empty;
                    string str = string.Empty;
                    int index = 0;
                    while ((str = await reader.ReadLineAsync()) != null)
                    {
                        txt1.AppendText(++index + str + "\n");
                    }
                }
            }
        }
        #endregion

        #region 下载文件
        private string filePath = string.Empty;
        /// <summary>
        /// 下载文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn3_Click(object sender, EventArgs e)
        {
            string urlStr = GetUrl();
            var client = GetWebClient(urlStr);
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "请选择文件存放位置";
            dialog.Filter = "静态页面(*.html)|*.html|文本文件(*.txt)|*.txt|图片文件(*.jpg)|*.jpg|所有文件(*.*)|*.*";
            dialog.FileName = "Temp";
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                filePath = dialog.FileName;
                client.DownloadFileAsync(new Uri(urlStr), filePath);
                client.DownloadFileCompleted += Client_DownloadFileCompleted;
            }
        }
        private void Client_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(filePath))
            {
                MessageBox.Show("下载失败");
            }
            else
            {
                var result = MessageBox.Show("下载成功是否打开文件？", "逆天友情提醒", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(filePath);
                }
            }
        }
        #endregion
    }
}
