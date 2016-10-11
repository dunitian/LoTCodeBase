using System;

namespace _04.数组扩容
{
    class Program
    {
        static void Main(string[] args)
        {
            DNTArray array = new DNTArray();
            array.Add("告").Add("诉").Add("你").Add("一").Add("个").Add("事").Add("情").Printf().WriteLine().Add("：明天放假").Printf();
            Console.ReadKey();
        }
    }
}
