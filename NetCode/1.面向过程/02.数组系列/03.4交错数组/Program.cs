using System;

namespace _03._4交错数组
{
    class Program
    {
        static void Main(string[] args)
        {
            //交错数组：一组一维数组，里面存放的又是一个个的数组，所以子数组类型必须和交错数组类型一致
            //前面的[]是代表它本质是一个数组，后面的[]代表它的元素又是一个一维数组，空间由你存入的数组决定
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