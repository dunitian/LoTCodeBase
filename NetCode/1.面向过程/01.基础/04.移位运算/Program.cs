using System;
namespace _04.位移运算
{
    class Program
    {
        static void Main(string[] args)
        {
            //X << N或X >> N，将X向左或右位移N位，位移结果类型与X相同。（X 只能是int，uint，long，ulong）

            //左位移 <<
            //eg: 100 << 2，将100向左位移2位，低位用0填充。
            //100 => 1100100 => 1100100 00 => 400
            Console.WriteLine(100 << 2);

            //右位移 >>
            //eg: 100 >> 2，将100向右位移2位，高位用0填充。
            //100 => 1100100 => 00 11001 => 25
            Console.WriteLine(100 >> 2);

            Console.ReadKey();
        }
    }
}
