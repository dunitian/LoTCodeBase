using System;

namespace _03._4简单工厂
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("昨天老师告诉小胖猎豹和老鹰以及蛇靠什么捕食");
            while (true)
            {

                Console.WriteLine("老师开始问问题了~~~【猎豹，老鹰，蛇】");
                Animal animal = GetAnimal(Console.ReadLine());
                if (animal == null)
                {
                    Console.WriteLine("老师上课没有讲~");
                }
                else
                {
                    animal.Eat();
                }
            }
        }

        /// <summary>
        /// 简单工厂
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private static Animal GetAnimal(string name)
        {
            Animal animal = null;
            switch (name)
            {
                case "蛇":
                    animal = new Snake();
                    break;
                case "老鹰":
                    animal = new Eagle();
                    break;
                case "猎豹":
                    animal = new Cheetah();
                    break;
            }
            return animal;
        }
    }
}
