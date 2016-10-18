using System;

namespace _03._3接口实现多态
{
    class Program
    {
        static void Main(string[] args)
        {
            IRun[] objs = { new Student(), new Cat() };
            foreach (var item in objs)
            {
                item.Runing();
            }
            Console.ReadKey();
        }
    }
}
