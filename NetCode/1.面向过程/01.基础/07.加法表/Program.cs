using System;

namespace _07.加法表
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int num;
                Console.WriteLine("请输入一个数字：");
                if (int.TryParse(Console.ReadLine(), out num))
                {
                    for (int i = 0; i <= num; i++)
                    {
                        Console.WriteLine($"{i}+{num - i}={num}");
                    }
                }
            }
        }
    }
}
