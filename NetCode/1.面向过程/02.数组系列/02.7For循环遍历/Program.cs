using System;

namespace _02._7For循环遍历
{
    class Program
    {
        static void Main(string[] args)
        {
            DNTArray array = new DNTArray();
            array.Add("这").Add("是").Add("一").Add("个").Add("测").Add("试").Add("。");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
            Console.ReadKey();
        }
    }
}
