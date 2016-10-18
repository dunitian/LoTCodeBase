using System;

namespace _10.邮箱格式验证_非正则_
{
    class Program
    {
        //验证电子邮箱的合法性：
        //接收用户输入的电子邮箱，判断是否合法
        // 1.必须包含 @和.LastIndexOf()   EndsWith()
        // 2.@必须在.的前面，@不能是第一位，.不能是最后一位，@和.之间必须有字符串
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (ValidateEamil(input))
                {
                    Console.WriteLine("输入正确");
                }
                else
                {
                    Console.WriteLine("输入格式不正确");
                }
            }
        }
        /// <summary>
        /// 验证邮箱格式
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private static bool ValidateEamil(string input)
        {
            int index1 = input.LastIndexOf('@');
            int index2 = input.LastIndexOf('.');
            if (index1 > 0 && index2 > 0 && !input.EndsWith(".") && index2 - index1 > 1)
            {
                return true;
            }
            return false;
        }
    }
}
