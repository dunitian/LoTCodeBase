using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace _1.临时控制台
{
    class Program
    {
        //密码可能会包含的字符集合
        static char[] charSources = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
                               'n',  'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        static int sLength = charSources.Length; //字符集长度	
        public static void Main(string[] args)
        {
            int maxLength = 2; //设置可能最长的密码长度
            HackerPass(maxLength);
            Console.Read();
        }

        //得到密码长度从 1到maxLength的所有不同长的密码集合
        public static void HackerPass(int maxLength)
        {
            for (int i = 1; i <= maxLength; i++)
            {
                char[] chars = new char[i];
                CreateDics(chars, i);
            }
        }

        //得到长度为len所有的密码组合，在字符集charSources中
        //递归表达式：fn(n)=fn(n-1)*sLenght; 大致是这个意思吧 
        private static void CreateDics(char[] chars, int len)
        {
            //递归出口
            if (len == 0)
            {  
                Console.WriteLine(new string(chars));
            }
            else
            {
                for (int i = 0; i < sLength; i++)
                {
                    chars[len - 1] = charSources[i];
                    CreateDics(chars, len - 1);
                }
            }
        }
    }
}
