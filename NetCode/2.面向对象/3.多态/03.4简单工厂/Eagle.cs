using System;

namespace _03._4简单工厂
{
    /// <summary>
    /// 老鹰
    /// </summary>
    public class Eagle : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("老鹰靠俯冲来捕食");
        }
    }
}
