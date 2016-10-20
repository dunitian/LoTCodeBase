using System.Collections;

namespace _1.集合为什么能用foreach遍历
{
    public partial class DNTArray// : IEnumerable //不见得一定要实现IEnumerable
    {
        /// <summary>
        /// 枚举器方法
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator()
        {
            return new MyEnumerator(this.array, this.index);
        }
    }
}
