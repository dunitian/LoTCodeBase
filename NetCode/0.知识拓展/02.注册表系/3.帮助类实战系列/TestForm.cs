using System;
using System.Windows.Forms;

namespace _3.帮助类实战系列
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        //查
        private void btn1_Click(object sender, EventArgs e)
        {
            var reg = RegistryHelper.SoftReg.FindKey("net");
            if (reg == null) { rtxt.AppendText("注册表中没有dnt注册项\n"); return; }

            var dic = reg.GetKeyValueDic();
            var subDic = reg.GetSubKeyValueDic();

            #region 循环遍历
            foreach (var item in dic)
            {
                rtxt.AppendText(string.Format("Key：{0} Value：{1}\n", item.Key, item.Value));
            }
            foreach (var item in subDic)
            {
                rtxt.AppendText(string.Format("Key：{0} Value：{1}\n", item.Key, item.Value));
            }
            #endregion
        }

        //增
        private void btn2_Click(object sender, EventArgs e)
        {
            var reg = RegistryHelper.SoftReg.AddSubItem("net").AddKeyValue("web", "http://www.asp.net").AddSubItem("Net Core").AddKeyValue("value", "http://docs.microsoft.com");
            if (reg == null)
            {
                rtxt.AppendText("添加失败\n");
            }
            else
            {
                rtxt.AppendText("添加成功\n");
            }
        }

        //改
        private void btn3_Click(object sender, EventArgs e)
        {
            var reg = RegistryHelper.SoftReg.FindKey("net");
            if (reg == null) { rtxt.AppendText("注册表中没有dnt注册项\n"); return; }
            reg.UpdateKeyValue("web", "http://asp.net").FindKey("Net Core").UpdateKeyValue("value", "https://microsoft.com");
            if (reg == null)
            {
                rtxt.AppendText("修改失败\n");
            }
            else
            {
                rtxt.AppendText("修改成功\n");
            }
        }

        //删
        private void btn4_Click(object sender, EventArgs e)
        {
            var reg = RegistryHelper.SoftReg.ClearSubAll("net");
            if (reg == null)
            {
                rtxt.AppendText("删除失败\n");
            }
            else
            {
                rtxt.AppendText("删除成功\n");
            }
        }

        private void clearlog_Click(object sender, EventArgs e)
        {
            rtxt.Clear();
        }
    }
}
