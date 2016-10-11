using System;

namespace _03.数组探讨
{
    class Program
    {
        static void Main(string[] args)
        {
            //&nums
            //    0x05b6e738 栈的地址
            //    * &nums: { 0 }
            int[] nums = new int[9];

            //&nums
            //    0x05b6e738 栈的地址
            //    * &nums: { 38148624 } //堆的地址
            nums = new int[9] { 1, 3, 5, 7, 9, 2, 4, 6, 8 };
            
            //nums={xxx,xxx}; 这种写法会报错 ==》引用类型存储是地址，所以不能将值赋值给地址引用

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
            Console.ReadKey();
        }
    }
}
