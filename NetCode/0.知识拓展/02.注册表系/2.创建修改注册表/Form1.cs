using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace _2.创建修改注册表
{
    public partial class Form1 : Form
    {
        public RegistryKey Reg { get; set; }
        public Form1()
        {
            InitializeComponent();
            //初始化
            var rootReg = Registry.LocalMachine;
            Reg = rootReg.OpenSubKey("software", true);//开权限
        }

        #region 公用方法
        /// <summary>
        /// 检验是否为空
        /// </summary>
        /// <param name="dntReg"></param>
        private bool KeyIsNull(RegistryKey dntReg)
        {
            if (dntReg == null)
            {
                rtxt.AppendText("注册表中没有dnt注册项\n");
                return true;
            }
            return false;
        }

        /// <summary>
        /// 遍历Key的Value
        /// </summary>
        /// <param name="reg"></param>
        private void ForeachRegKeys(RegistryKey reg)
        {
            rtxt.AppendText(string.Format("\n SubKeyCount：{0} ValueCount：{1} FullName：{2}\n", reg.SubKeyCount, reg.ValueCount, reg.Name));
            foreach (var name in reg.GetValueNames())
            {
                rtxt.AppendText(string.Format("Name：{0} Value：{1} Type：{2}\n", name, reg.GetValue(name), reg.GetValueKind(name)));
            }
        }
        #endregion

        //查
        private void btn1_Click(object sender, EventArgs e)
        {
            var dntReg = Reg.OpenSubKey("dnt");
            if (KeyIsNull(dntReg)) return;
            ForeachRegKeys(dntReg);
            foreach (var item in dntReg.GetSubKeyNames())
            {
                //以只读方式检索子项
                RegistryKey sonKey = dntReg.OpenSubKey(item);
                ForeachRegKeys(sonKey);
            }
        }

        //增
        private void btn2_Click(object sender, EventArgs e)
        {
            var dntReg = Reg.CreateSubKey("dnt");
            dntReg.SetValue("web", "http://www.dkill.net");
            var sonReg = dntReg.CreateSubKey("path");
            sonReg.SetValue("value", "D:\\Program Files\\dnt");
            rtxt.AppendText("添加成功\n");
        }

        //改
        private void btn3_Click(object sender, EventArgs e)
        {
            var dntReg = Reg.OpenSubKey("dnt", true);
            if (KeyIsNull(dntReg)) return;
            dntReg.SetValue("web", "http://dnt.dkill.net");
            rtxt.AppendText("修改成功\n");
        }

        //删
        private void btn4_Click(object sender, EventArgs e)
        {
            try
            {
                #region 删除某个值
                //var dntReg = Reg.OpenSubKey("dnt", true);
                //if (KeyIsNull(dntReg)) return;
                //dntReg.DeleteValue("web", false);
                #endregion
                Reg.DeleteSubKeyTree("dnt",false);
                rtxt.AppendText("删除成功\n");
            }
            catch (ArgumentException ex)
            {
                rtxt.AppendText(ex.ToString());
            }
        }

        private void clearlog_Click(object sender, EventArgs e)
        {
            rtxt.Clear();
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void rtxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
