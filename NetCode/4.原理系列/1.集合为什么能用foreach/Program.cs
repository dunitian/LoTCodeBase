using System;

namespace _1.集合为什么能用foreach遍历
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 演示
            string[] strs = { "这", "是", "一", "个", "演示" };
            //for (int i = 0; i < strs.Length; i++)
            //{
            //    Console.WriteLine(strs[i]);
            //}
            //foreach (var item in strs)
            //{
            //    Console.WriteLine(item);
            //}

            //IEnumerator enumerator = strs.GetEnumerator();
            //while (enumerator.MoveNext())
            //{
            //    Console.WriteLine(enumerator.Current);
            //} 
            #endregion

            DNTArray array = new DNTArray();
            array.Add("这").Add("是").Add("一").Add("个").Add("测").Add("试");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
            Console.WriteLine();
            foreach (var item in array)
            {
                Console.Write(item);
            }
            Console.ReadKey();
        }
    }
}
