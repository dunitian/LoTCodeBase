using System;

namespace _01.封装_类
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student() { Name = "mmd", Age = 13, Gender = 1 };
            s.Show();
            Student s1 = new Student("dmm", 20);
            s1.Show();
            Console.ReadKey();
        }
    }
}
