using System;

namespace NetBase
{
    class Program
    {
        /// <summary>
        /// 请交换两个int类型的变量，要求不能使用中间变量
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int num1 = 21;
            int num2 = 12;
            Console.WriteLine("num1： " + num1 + "  num2： " + num2);
            num1 = num1 + num2;//x=x+y
            num2 = num1 - num2;//y=(x+y)-y=x
            num1 = num1 - num2;//x=(x+y)-x=y
            Console.WriteLine("num1： " + num1 + "  num2： " + num2);
            
            //new add:
            int x = 3, y = 5;
            (x, y) = (y, x);
            Console.WriteLine("x： " + x + "  y： " + x);
            Console.ReadKey();
        }
    }
}
