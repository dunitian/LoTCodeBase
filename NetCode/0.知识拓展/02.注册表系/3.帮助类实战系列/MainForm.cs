using System;
using System.Windows.Forms;

namespace _3.帮助类实战系列
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Helper演示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn1_Click(object sender, EventArgs e)
        {
            var form = new TestForm();
            form.Show();
        }

        /// <summary>
        /// 隐藏我的电脑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn2_Click(object sender, EventArgs e)
        {
            SetComputerIcon(1);
        }
        /// <summary>
        /// 显示我的电脑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn3_Click(object sender, EventArgs e)
        {
            SetComputerIcon(0);
        }

        /// <summary>
        /// 禁用右击菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn4_Click(object sender, EventArgs e)
        {
            SetRightMenu(1);
        }

        /// <summary>
        /// 启用右击菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn5_Click(object sender, EventArgs e)
        {
            SetRightMenu(0);
        }

        private void SetRightMenu(int i)
        {
            RegistryHelper.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", false).UpdateKeyValue("NoViewContextMenu", i);
        }

        private static void SetComputerIcon(int i)
        {
            RegistryHelper.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", false).UpdateKeyValue("20D04FE0-3AEA-1069-A2D8-08002B30309D", i);
        }
    }
}
