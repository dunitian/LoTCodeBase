using System;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._3.IPEndPoint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            IpEndPointInfo();
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
        private void IpEndPointInfo()
        {
            var ipEndPoint = new System.Net.IPEndPoint(IPAddress.Parse(GetUrl()), 443);
            MessageBox.Show(string.Format("IP:{0},Point:{1}", ipEndPoint.Address.ToString(), ipEndPoint.Port));
        }
        #endregion
    }
}
