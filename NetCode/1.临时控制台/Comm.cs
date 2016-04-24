using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.临时控制台
{
    #region 案例
    //string src_str = "ab#c#def#gh#ijk#lmn#opq#rst#uvw#xyz";
    //string[] str_list = src_str.Split('#');
    //List<string> result = new List<string>();
    //Comm.GenCom(str_list, 2, result);
    //result = result.Distinct().ToList();
    //for (int i = 0; i<result.Count; ++i)
    //{
    //    Console.WriteLine(result[i]);
    //}
    //Console.WriteLine(result.Count); 
    #endregion
    /// <summary>
    /// 组合算法+笛卡尔积
    /// </summary>
    public static class Commbak
    {
        #region 计算字符串笛卡尔积(一维数组乘积)-使用堆栈算法，不使用递归
        private static void Descartes(List<string> str_list, List<string> result)
        {
            List<char[]> result_char_list = new List<char[]>();

            int index = 0;

            while (index < str_list.Count)
            {
                string cur_str = str_list[index];

                if (index == 0)
                {
                    for (int i = 0; i < cur_str.Length; ++i)
                    {
                        char[] tmp = new char[str_list.Count];
                        tmp[index] = cur_str[i];
                        result_char_list.Add(tmp);
                    }
                }
                else
                {
                    List<char[]> tmp_char_list = new List<char[]>();
                    tmp_char_list.AddRange(result_char_list);
                    result_char_list.Clear();

                    for (int i = 0; i < tmp_char_list.Count; ++i)
                    {
                        for (int k = 0; k < cur_str.Length; ++k)
                        {
                            char[] tmp = tmp_char_list[i];
                            tmp[index] = cur_str[k];
                            result_char_list.Add(tmp);
                        }
                    }
                }
                index++;
            }

            for (int i = 0; i < result_char_list.Count; ++i)
            {
                result.Add(new string(result_char_list[i]));
            }
        }
        #endregion

        #region 按标志位组合字符串
        private static void MakeCom(string[] str_list, bool[] flags, List<string> result)
        {
            List<string> choice_str = new List<string>();

            for (int i = 0; i < str_list.Length; ++i)
            {
                if (flags[i] == true)
                {
                    choice_str.Add(str_list[i]);
                }
            }
            Descartes(choice_str, result);//选择完，计算笛卡尔积
        }
        #endregion

        //组合算法,n为串数
        //核心算法:选号标记移位算法(选择该位为true,不选为false)，选号标记总最左(栈底)开始，循环移至最右(栈顶)。
        //移动选号位的选择：从最左边(栈底)起向右(栈顶)查询，最近一个上位有空位(false)的选号位(true)
        //将选定的选号位向右移一位(升栈)，左边标记位全部降至左边(栈底)
        //循环上面两个流程至全部选号位移至最右(栈顶)
        public static void GenCom(string[] str_list, int n, List<string> result)
        {
            if (n <= 0 || n > str_list.Length)
            {
                return;
            }
            //标志数组
            bool[] flags = new bool[str_list.Length];

            //初始化前n是选号位
            for (int i = 0; i < n; i++)
            {
                flags[i] = true;
            }
            //后面都是非选号位
            for (int i = n; i < str_list.Length; i++)
            {
                flags[i] = false;
            }

            //计算初始化组合
            MakeCom(str_list, flags, result);

            while (true)
            {
                int num_count = 0;  //从最左边起，连续邻位true true的个数
                bool move = false;   //是否进行了移位

                //找邻位true false组合
                for (int i = 0; i < str_list.Length - 1; ++i)   //前置1位防越界
                {
                    if (flags[i])
                    {
                        if (flags[i + 1]) //true true邻位组合，继续向右查找
                        {
                            num_count++;
                        }
                        else        //第一个可升位位置
                        {
                            //相邻选号位true false变换为false true
                            //实现升栈
                            flags[i] = false;
                            flags[i + 1] = true;

                            //左边选号位将至栈底
                            for (int j = 0; j < num_count; j++)
                            {
                                flags[j] = true;
                            }
                            for (int j = num_count; j < i; j++)
                            {
                                flags[j] = false;
                            }

                            move = true;
                            break;
                        }
                    }
                }

                if (move)
                {
                    MakeCom(str_list, flags, result);
                }
                else
                {
                    break;
                }
            }
        }
    }
}
