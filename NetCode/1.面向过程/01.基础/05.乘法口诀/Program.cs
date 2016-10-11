using System;

namespace _05.乘法口诀
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} * {i} = {i * j}  ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}