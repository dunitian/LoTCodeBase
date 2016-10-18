using System;

namespace _03._4简单工厂
{
    /// <summary>
    /// 猎豹
    /// </summary>
    public class Cheetah : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("猎豹靠奔跑来捕食");
        }
    }
}
