using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._1.DNS
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
                MessageBox.Show("请输入域名地址！");
                return string.Empty;
            }

            return urlStr;
        } 
        #endregion

        #region 输出IP地址
        /// <summary>
        /// 输出IP地址
        /// </summary>
        /// <param name="urlStr"></param>
        /// <returns></returns>
        private async Task PrintIpArray()
        {
            var ips = await NetHelper.GetHostAddresses(GetUrl());
            string str = string.Empty;
            foreach (var item in ips)
            {
                str += string.Format("\n{0}", item);
            }
            MessageBox.Show(str, "IP地址");
        }
        #endregion

        #region 获取PC Name
        /// <summary>
        /// 获取PC Name
        /// </summary>
        private string GetPCName()
        {
            return NetHelper.GetPCName();
        }
        #endregion

        #region 获取DNS 信息
        /// <summary>
        /// 获取DNS 信息
        /// </summary>
        /// <param name="address"></param>
        //private string GetDNSName(string address)
        private async Task GetDNSName(string address)
        {
            MessageBox.Show("DNS Name：" + await NetHelper.GetDNSInfo(address));
        }
        #endregion

        #region 按钮单击事件
        //获取IP地址
        private void btn1_Click(object sender, EventArgs e)
        {
            Task.Run(() => PrintIpArray());
        }
        //获取DNS
        private void btn3_Click(object sender, EventArgs e)
        {
            Task.Run(() => GetDNSName(GetUrl()));
        }
        //获取PCName
        private void btn2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PC Name：" + GetPCName());
        }
        //获取本机DNS
        private void btn4_Click(object sender, EventArgs e)
        {
            Task.Run(() => GetDNSName(GetPCName()));
        } 
        #endregion
    }
}
