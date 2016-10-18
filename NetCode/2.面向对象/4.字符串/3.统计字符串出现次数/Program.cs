using System;

namespace _12.统计字符串出现次数
{
    class Program
    {
        //根据用户输入的字符串，查询“abc”出现的次数
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("等待用户输入：");
                string input = Console.ReadLine();
                int count = TotalStrCount(input);
                Console.WriteLine($"“abc”出现了{count}次");
            }
        }

        /// <summary>
        /// 统计Str出现次数
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private static int TotalStrCount(string input)
        {
            int count = 0;
            int index = input.IndexOf("abc");

            while (index != -1)
            {
                count++;
                index = input.IndexOf("abc", index + 3);//index指向abc的后一位
            }
            return count;
        }
    }
}
