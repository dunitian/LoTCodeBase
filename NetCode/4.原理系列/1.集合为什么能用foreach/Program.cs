using System;
using System.Collections.Generic;

namespace _1.集合为什么能用foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string>() { "111", "222", "333", "555" };
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            var obj = new MyClass();
            obj.Names = new string[] { "PHP", "JAVA", "IOS" };
            foreach (var item in obj.Names)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
