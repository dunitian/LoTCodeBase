using System;

namespace _08.数组反序
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strs = { "我", "是", "毒", "逆", "天" };
            Printf(strs);
            for (int i = 0; i < strs.Length / 2; i++)
            {
                string temp = strs[strs.Length - 1 - i];
                strs[strs.Length - 1 - i] = strs[i];
                strs[i] = temp;
            }
            Printf(strs);
            Console.ReadKey();
        }

        private static void Printf(string[] strs)
        {
            Console.WriteLine("数组现在为：");
            for (int i = 0; i < strs.Length; i++)
            {
                Console.WriteLine(strs[i]);
            }
        }
    }
}
