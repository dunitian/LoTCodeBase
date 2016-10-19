using System;

namespace _10.递归案例
{
    class Program
    {
        //一列数的规则如下: 1、1、2、3、5、8、13、21、34...... 求第30位数是多少， 用递归算法实现
        static void Main(string[] args)
        {
            //1     2       3       4       5           n
            //1     1      1+1     2+1     3+2   Fn(n-2)+Fn(n-1)
            Console.WriteLine(GetNum(30));
            Console.ReadKey();
        }
        /// <summary>
        /// 递归就这么理解，先找能打破重复的条件，然后就不断的重复去吧
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        private static int GetNum(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }
            else
            {
                return GetNum(n - 1) + GetNum(n - 2);
            }

        }
    }
}
