using System;

namespace EnumStart
{
    enum Test
    {
        mmd,
        dzy,
        atm,
        ymt
    }
    class Program
    {
        static void Main(string[] args)
        {
            int temp = Convert.ToInt32(Test.mmd);
            Console.WriteLine(temp);
            Console.ReadKey();
        }
    }
}
