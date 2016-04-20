using System;

namespace _03._4交错数组
{
    class Program
    {
        static void Main(string[] args)
        {
            //交错数组：它的本质是一个一维数组，但是这个数组里面的每一个元素又是一个一维数组,子数组的类型必须和交错数组类型一致，否则报错
            //前面的[]是代表它本质是一个数组，后面的[]代表它的元素又是一个一维数组，为什么后面不需确定数值呢？因为你根本不知道,开始的时候数组里面每一个元素都是null
            int[][] nums = new int[3][];
            //给其中一个赋值
            nums[2] = new int[3] { 1, 2, 3 };
            for (int i = 0; i < nums.Length; i++)
            {
                //注意没赋值的情况（null）
                if (nums[i] == null) { continue; }
                for (int j = 0; j < nums[i].Length; j++)
                {
                    Console.Write(nums[i][j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
