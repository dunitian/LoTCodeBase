namespace _04.数组扩容
{
    public class DArray
    {
        //下标
        int count = 0;

        //初始化空间
        public string[] strs = new string[2];

        /// <summary>
        /// 添加元素
        /// </summary>
        /// <param name="str">值</param>
        /// <returns></returns>
        public DArray Add(string str)
        {
            //空间不够的时候开辟新空间
            if (count == strs.Length)
            {
                string[] strsTemp = new string[count * 2];
                strs.CopyTo(strsTemp, 0);
                strs = strsTemp;
            }
            strs[count++] = str;
            return this;
        }

        /// <summary>
        /// 输出
        /// </summary>
        /// <returns></returns>
        public DArray Output()
        {
            for (int i = 0; i < count; i++)
            {
                System.Console.Write(strs[i]);
            }
            return this;
        }
    }

}