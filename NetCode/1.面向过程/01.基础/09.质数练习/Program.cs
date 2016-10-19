using System;

namespace _09.质数练习
{
    class Program
    {
        /// <summary>
        /// 输出0~100中所有的质数
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (IsMassNum(i))
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
        /// <summary>
        /// 是否是质数
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        private static bool IsMassNum(int i)
        {
            for (int j = 2; j < i; j++)
            {
                if (i % j == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
