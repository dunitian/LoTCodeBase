using System;

namespace _03._1虚方法实现多态
{
    public class Gril : Person
    {
        #region 构造函数
        public Gril() { }
        public Gril(string name, bool gender) : base(name, gender) { }
        public Gril(string name, bool gender, short age) : base(name, gender, age) { }
        #endregion

        /// <summary>
        /// 重写父类方法
        /// </summary>
        public override void SaiHi()
        {
            string genderStr = Gender == true ? "男孩" : "女孩";
            Console.WriteLine($"你好，我叫{Name}，今年{Age}岁了，我是一个腼腆的小{genderStr}");
        }
    }
}
