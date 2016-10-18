using System;

namespace _03._4简单工厂
{
    /// <summary>
    /// 蛇
    /// </summary>
    public class Snake : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("蛇靠突袭来捕食");
        }
    }
}
