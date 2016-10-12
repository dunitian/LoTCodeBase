using System;

namespace _03._6数值插入2
{
    /// <summary>
    /// 要求：一个循环实现数组有序插入
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 3, 5, 9, 10, 11 };//原来的数组            
            int[] newArray = new int[array.Length + 1];//定义一个新的数组

            int num;//等待输入的数字

            do
            {
                Printf(array);
                if (int.TryParse(Console.ReadLine(), out num))
                {
                    InsertNumToArray(array, newArray, num);
                    PrintfArray(newArray);
                }
            } while (true);
        }

        /// <summary>
        /// 插入数字到数组中
        /// 这种思想C基础中用的比较多
        /// </summary>
        /// <param name="array"></param>
        /// <param name="newArray"></param>
        /// <param name="num"></param>
        private static void InsertNumToArray(int[] array, int[] newArray, int num)
        {
            bool b = true;//标识
            for (int i = 0; i < array.Length; i++)
            {
                if (num < array[i])
                {
                    if (b)
                    {
                        b = false;
                        newArray[i] = num;
                    }
                    newArray[i + 1] = array[i];
                }
                else
                {
                    newArray[i] = array[i];
                }
            }
            //当这个数是最大数的时候
            if (b)
            {
                newArray[newArray.Length - 1] = num;
            }
        }

        /// <summary>
        /// 运行时提示
        /// </summary>
        /// <param name="array"></param>
        private static void Printf(int[] array)
        {
            Console.Write("\n当前数组是：");
            PrintfArray(array);
            Console.WriteLine("\n请插入一个数字：");
        }

        /// <summary>
        /// 便利输出
        /// </summary>
        /// <param name="newArray"></param>
        private static void PrintfArray(int[] newArray)
        {
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.Write($"{newArray[i]} ");
            }
        }
    }
}
