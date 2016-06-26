using System;
using System.Collections.Generic;

namespace _03.异或运算
{
    class Program
    {
        static void Main(string[] args)
        {
            //按位异或
            //相同则0,不同则1
            //1  => 0000 0001
            //     -----------
            //85 => 0101 0101
            //     -----------
            //      0101 0100 => 84
            Console.WriteLine("==逆天想了套加密，给你们点灵感==\n===============================");
            Console.WriteLine("1 ^ 85：{0}", 1 ^ 85);
            Console.WriteLine("2 ^ 85：{0}", 2 ^ 85);
            Console.WriteLine("3 ^ 85：{0}", 3 ^ 85);
            Console.WriteLine("4 ^ 85：{0}", 4 ^ 85);
            Console.WriteLine("===============================");
            Console.WriteLine("1 ^ 84：{0}", 1 ^ 84);
            Console.WriteLine("2 ^ 87：{0}", 2 ^ 87);
            Console.WriteLine("3 ^ 86：{0}", 3 ^ 86);
            Console.WriteLine("4 ^ 81：{0}", 4 ^ 81);

            //布尔异或(相同false（0），异同true（1）)
            Console.WriteLine(true ^ true);
            Console.WriteLine(true ^ false);
            Console.WriteLine(false ^ true);
            Console.WriteLine(false ^ false);
            Console.ReadKey();
        }
    }
}
