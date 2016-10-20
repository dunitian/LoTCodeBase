namespace _02._7For循环遍历
{
    /// <summary>
    /// 使DNTArray能够For循环遍历
    /// </summary>
    public partial class DNTArray
    {
        /// <summary>
        /// 数组容量
        /// </summary>
        private string[] array = new string[4];
        /// <summary>
        /// 数组当前索引
        /// </summary>
        private int index = 0;
        /// <summary>
        /// 当前数组的长度
        /// </summary>
        public int Length
        {
            get
            {
                return index + 1;
            }
        }

        /// <summary>
        /// 添加元素
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public DNTArray Add(string str)
        {
            //要溢出的时候扩容
            if (index == array.Length)
            {
                string[] newArray = new string[2 * array.Length];
                array.CopyTo(newArray, 0);
                array = newArray;//array重新指向
            }
            array[index++] = str;
            return this;
        }
        /// <summary>
        /// 索引器
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public string this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                array[index] = value;
            }
        }
    }
}
