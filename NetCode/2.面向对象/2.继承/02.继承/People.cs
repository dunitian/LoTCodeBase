using System;

namespace _02.继承
{
    public class People
    {
        /// <summary>
        ///ushort参考： https://msdn.microsoft.com/zh-CN/library/cbf1574z.aspx
        /// </summary>
        public string Name { get; set; }
        public ushort Age { get; set; }

        public People(string name, ushort age)
        {
            this.Name = name;
            this.Age = age;
        }
        public void Hi()//People
        {
            Console.WriteLine("Name: " + this.Name + " Age: " + this.Age);
        }
        public virtual void Show()//People
        {
            Console.WriteLine("Name: " + this.Name + " Age: " + this.Age);
        }
    }
}
