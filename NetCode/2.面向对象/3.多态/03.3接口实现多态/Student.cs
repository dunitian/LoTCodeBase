using System;

namespace _03._3接口实现多态
{
    public class Student : IRun
    {
        public void Runing()
        {
            Console.WriteLine("飞快的跑着去上课");
        }
    }
}
