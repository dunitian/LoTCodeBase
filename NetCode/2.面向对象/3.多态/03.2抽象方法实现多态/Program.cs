using System;

namespace _03._2抽象方法实现多态
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = { new Dog(), new Cat() };
            foreach (var item in animals)
            {
                item.Call();
            }
            Console.ReadKey();
        }
    }
}
