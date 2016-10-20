using System;


namespace 饲养员喂食案例
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("饲养员开始喂食了~");

            Person p = new Person();
            p.Feed(new Tiger(), new Meat());
            p.Feed(new Monkey(), new Banana());
            p.Feed(new Rabbit(), new Carrot());

            Console.ReadKey();
        }
    }
}
