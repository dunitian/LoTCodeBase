using System;

namespace _06.常见几何
{
    /// <summary>
    /// 用循环来速出以下图形（每次输出只能一个 *）
    /// 考察的目的：for循环灵活使用 + 基本数学思想
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int n;
                Console.WriteLine("请输入边长：（默认是 5）");
                if (!int.TryParse(Console.ReadLine(), out n))
                {
                    n = 3;//转换失败赋默认值
                }

                PrintTriangle(n);
                PrintParallelogram(n);
                PrintDownTriangle(n);
                PrintSquare(n);
                PrintLozenge(n);
            } while (true);
        }


        /// <summary>
        /// 正三角
        /// </summary>
        private static void PrintTriangle(int n)
        {
            #region 简单版本
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region 美化版本
            //行数
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i + 1; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("* ");
                }
                for (int j = 0; j < n - i + 1; j++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine();
            }
            #endregion
        }

        /// <summary>
        /// 倒三角
        /// </summary>
        private static void PrintDownTriangle(int n)
        {
            #region 简单版本
            ////行数
            //for (int i = 0; i < n; i++)
            //{
            //    //个数
            //    for (int j = 0; j < n - i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region 美化版本
            for (int i = n - 1; i >= 0; i--)
            {
                for (int j = 0; j < n - i + 1; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("* ");
                }
                for (int j = 0; j < n - i + 1; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            #endregion
        }

        /// <summary>
        /// 平行四边形
        /// </summary>
        /// <param name="n"></param>
        private static void PrintParallelogram(int n)
        {
            #region 简化版本
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < n; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            #endregion
        }

        /// <summary>
        /// 正方形
        /// </summary>
        private static void PrintSquare(int n)
        {
            #region 简单版本
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //} 
            #endregion

            #region 美化版本
            for (int i = 0; i < n; i++)
            {
                if (i == 0 || i == n - 1)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write("* ");
                    }
                }
                else
                {
                    Console.Write("*");
                    for (int j = 0; j < n * 2 - 3; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            #endregion
        }

        /// <summary>
        /// 菱形
        /// </summary>
        private static void PrintLozenge(int n)
        {
            #region 简化版本
            //正三角
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                for (int j = 0; j < n - i; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            //倒三角
            for (int i = n - 1; i >= 0; i--)
            {
                for (int j = 0; j < n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                for (int j = 0; j < n - i; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            #endregion
        }
    }
}

