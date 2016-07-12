using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3._3.SmtpClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task.Run(SendMsg);
        }
        public async Task SendMsg()
        {
            bool b = await EmailHelper.SendAsync("1054186320@qq.com", "test标题", "test内容");
            MessageBox.Show(b.ToString());
        }
    }
}
