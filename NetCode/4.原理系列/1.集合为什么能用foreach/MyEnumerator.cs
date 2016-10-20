using System.Collections;

namespace _1.集合为什么能用foreach遍历
{
    public class MyEnumerator : IEnumerator
    {
        /// <summary>
        /// 需要遍历的数组
        /// </summary>
        private string[] array;
        /// <summary>
        /// 有效数的个数
        /// </summary>
        private int count;
        public MyEnumerator(string[] array, int index)
        {
            this.array = array;
            this.count = index + 1;
        }

        /// <summary>
        /// 当前索引（线moveNext再获取index，用-1更妥）
        /// </summary>
        private int index = -1;
        public object Current
        {
            get
            {
                return array[index];
            }
        }
        /// <summary>
        /// 移位
        /// </summary>
        /// <returns></returns>
        public bool MoveNext()
        {
            if (++index < count)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// 重置
        /// </summary>
        public void Reset()
        {
            index = -1;
        }
    }
}
