using System;

namespace _03._3多维数组
{
    class Program
    {
        static void Main(string[] args)
        {
            TwoArray();
            //ThreeArray();
            Console.ReadKey();
        }

        /// <summary>
        /// 三维数组
        /// </summary>
        private static void ThreeArray()
        {
            int[,,] nums = new int[3, 4, 5];
            //[3,4,5] => 3
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                //[3,4,5] => 4
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    //[3,4,5] => 5
                    for (int k = 0; k < nums.GetLength(2); k++)
                    {
                        Console.Write(nums[i, j, k] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// 二维数组
        /// </summary>
        private static void TwoArray()
        {
            int[,] nums = new int[7, 9];//二维数组
            Console.WriteLine(nums.Length);  //Length是指可以存储元素的个数（7*9）
            //控制遍历第几行，arr.GetLength(0) 0代表--获取第一个元素的下标总数
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                //控制遍历这一行中的每一列（每一个元素）
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    Console.Write(nums[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
