using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0.ToString性能比较
{
    class Program
    {
        static void Main(string[] args)
        {
            Task.Run(() => RunOne());
            Task.Run(() => RunTwo());
            Console.ReadKey();
        }
        public static void RunOne()
        {
            Console.WriteLine("ToString开始：\n");
            Stopwatch timer = new Stopwatch();
            timer.Start();
            for (int i = 0; i < 900000000; i++)
            {
                i.ToString();
            }
            timer.Stop();
            Console.WriteLine($"ToString耗时：{timer.ElapsedMilliseconds}");
        }
        public static void RunTwo()
        {
            Console.WriteLine("string.Concat开始：\n");
            Stopwatch timer = new Stopwatch();
            timer.Start();
            for (int i = 0; i < 900000000; i++)
            {
                string.Concat(i);
            }
            timer.Stop();
            Console.WriteLine($"string.Concat耗时：{timer.ElapsedMilliseconds}");
        }
    }
}
