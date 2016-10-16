using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._2抽象方法实现多态
{
    public class Dog : Animal
    {
        /// <summary>
        /// 子类必须实现抽象类中的抽象方法
        /// </summary>
        public override void Call()
        {
            Console.WriteLine("汪汪叫~~~");
        }
    }
}
