using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._2.IPAddress
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Task.Run(() => PrintIpArray());
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
                str += string.Format("\nIP地址族：{0}，IPV4：{1}，是否是IPV6：{2}", item.AddressFamily, item.MapToIPv4(), item.IsIPv6LinkLocal);
            }
            MessageBox.Show(str, "IP地址");
        }
        #endregion
    }
}
