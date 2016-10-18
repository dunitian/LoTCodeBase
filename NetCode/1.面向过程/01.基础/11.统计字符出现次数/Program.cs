using System;
using System.Collections.Generic;

namespace _11.统计字符出现次数
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "abacddeabca";
            Dictionary<char, int> dic = new Dictionary<char, int>();
            for (int i = 0; i < str.Length; i++)
            {
                //存在就count++
                if (dic.ContainsKey(str[i]))
                {
                    dic[str[i]]++;
                }
                else
                {
                    dic.Add(str[i], 1);
                }
            }
            PrintfDic(dic);
            Console.ReadKey();
        }

        private static void PrintfDic(Dictionary<char, int> dic)
        {
            foreach (var item in dic)
            {
                Console.WriteLine($"{item.Key}=={item.Value}");
            }
        }
    }
}
