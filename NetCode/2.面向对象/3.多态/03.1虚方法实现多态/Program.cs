using System;

namespace _03._1虚方法实现多态
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = { new Person(), new Boy("铁锅", true, 13), new Gril("妞妞", false, 22) };
            foreach (var item in persons)
            {
                //看看item里面到底放的是什么
                Console.WriteLine(item.ToString());
                item.SaiHi();
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
