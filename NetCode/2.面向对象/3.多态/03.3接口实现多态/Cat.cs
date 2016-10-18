using System;

namespace _03._3接口实现多态
{
    public class Cat : IRun
    {
        public void Runing()
        {
            Console.WriteLine("飞快的跑着上树");
        }
    }
}
