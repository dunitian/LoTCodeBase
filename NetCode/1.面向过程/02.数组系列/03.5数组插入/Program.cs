using System;

namespace _03._5数组插入
{
    class Program
    {
        static void Main(string[] args)
        {
            //有一个整型类型的数组，已经排好序，请完成以下功能：(不要使用插入后数组的排序方法)
            //    1.插入一个新的数据
            //    2.插入后数组仍然是排好序的
            int input;
            int[] nums = { 1, 3, 5, 7, 9 };
            int[] array = new int[nums.Length + 1];
            do
            {
                Console.WriteLine("\n请输入一个整数");
                int.TryParse(Console.ReadLine(), out input);
                //copy to array[]
                nums.CopyTo(array, 0);
                int index = nums.Length;//考虑到最大的时候(每次循环必须重置【不然影响默认值】)
                for (int i = 0; i < nums.Length; i++)
                {
                    if (input < nums[i])
                    {
                        index = i;
                        break;
                    }
                }
                //移动后面的数字
                for (int i = array.Length - 1; i > index; i--)
                {
                    array[i] = array[i - 1];
                }
                array[index] = input;
                //输出
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + " ");
                }
            } while (true);
        }
    }
}
