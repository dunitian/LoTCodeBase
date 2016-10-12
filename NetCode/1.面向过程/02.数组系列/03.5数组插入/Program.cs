using System;

namespace _03._5数组插入
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int[] array = new int[6] { 1, 3, 5, 7, 9, 13 };
                int[] newArray = new int[array.Length + 1];
                array.CopyTo(newArray, 0);
                int num;

                Printf(array);

                if (int.TryParse(Console.ReadLine(), out num))
                {
                    InsertNumToArray(array, newArray, num);
                    PrintfArray(newArray);
                }

            } while (true);
        }
        /// <summary>
        /// 插入数字
        /// </summary>
        /// <param name="array"></param>
        /// <param name="newArray"></param>
        /// <param name="num"></param>
        /// <param name="position"></param>
        /// <returns></returns>
        private static void InsertNumToArray(int[] array, int[] newArray, int num)
        {
            #region 原始版本
            //int position = -1;

            ////寻找该插入的位置
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (num < array[i])
            //    {
            //        position = i;
            //        break;
            //    }
            //}
            ////填充空位
            //if (position == -1)
            //{
            //    newArray[newArray.Length - 1] = num;//num最大
            //}
            //else
            //{
            //    //从该位置起，整体往后移动一位
            //    for (int i = newArray.Length - 1; i > position; i--)
            //    {
            //        newArray[i] = newArray[i - 1];
            //    }
            //    newArray[position] = num;
            //} 
            #endregion

            #region 简化版本
            int position = newArray.Length - 1;//直接就把最大的情况考虑进去了

            //寻找该插入的位置
            for (int i = 0; i < array.Length; i++)
            {
                if (num < array[i])
                {
                    position = i;
                    break;
                }
            }
            //填充空位   //从该位置起，整体往后移动一位
            for (int i = newArray.Length - 1; i > position; i--)
            {
                newArray[i] = newArray[i - 1];
            }
            newArray[position] = num;
            #endregion
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
