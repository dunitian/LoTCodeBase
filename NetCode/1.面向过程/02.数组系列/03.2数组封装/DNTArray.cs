namespace _04.数组扩容
{
    public class DNTArray
    {
        string[] array = new string[2];
        int index = 0;

        /// <summary>
        /// 添加元素
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public DNTArray Add(string item)
        {
            if (index == array.Length)
            {
                string[] newArray = new string[array.Length * 2];
                array.CopyTo(newArray, 0);
                array = newArray;//改变引用地址
            }
            array[index++] = item;
            return this;
        }

        public DNTArray Printf()
        {
            for (int i = 0; i < index; i++)
            {
                System.Console.Write(array[i]);
            }
            return this;
        }

        public DNTArray WriteLine()
        {
            System.Console.WriteLine();
            return this;
        }
    }

}