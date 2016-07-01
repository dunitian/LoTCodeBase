using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace _1.注册表基础
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //RegistryKey
        //属性：
        //      ValueCount  检索项中值的计数
        //      SubKeyCount 获取子项个数

        //方法：
        //      OpenSubKey(string name)             获取子项 RegistryKey（只读）
        //      GetSubKeyNames()                    获取所有子项名称的字符串数组
        //      GetValueNames()                     检索包含与此项关联的所有值名称的字符串数组
        //      GetValue(string name)               获取指定名称,不存在名称/值对，则返回 null
        //      CreateSubKey(string subkey)         创建或者打开子项的名称或路径
        //      SetValue(string name,object value)  创建或者打开子项的名称或路径
        //      DeleteSubKeyTree(string subkey)     递归删除指定目录，不存在则抛异常
        //      DeleteSubKey(string subkey,bool b)  删除子项，b为false则当子项不存在时不抛异常
        //      DeleteValue(string name,bool b)     删除指定的键值，b为false则当子项不存在时不抛异常

        private void btn1_Click(object sender, EventArgs e)
        {
            //获取一个表示HKLM键的RegistryKey
            RegistryKey rk = Registry.LocalMachine;

            //打开HKLM的子项Software
            RegistryKey subKey = rk.OpenSubKey(@"software");

            //遍历所有子项名称的字符串数组
            foreach (var item in subKey.GetSubKeyNames())
            {
                //以只读方式检索子项
                RegistryKey sonKey = subKey.OpenSubKey(item);

                rtxt.AppendText(string.Format("\n--->{0}<---\nSubKeyCount：{1} ValueCount：{2} FullName：{3}\n==================================\n", item, sonKey.SubKeyCount, sonKey.ValueCount, sonKey.Name));

                //检索包含与此项关联的所有值名称的字符串数组
                foreach (var name in sonKey.GetValueNames())
                {
                    rtxt.AppendText(string.Format("Name：{0} Value：{1} Type：{2}\n", name, sonKey.GetValue(name), sonKey.GetValueKind(name)));
                }
            }
        }
    }
}
