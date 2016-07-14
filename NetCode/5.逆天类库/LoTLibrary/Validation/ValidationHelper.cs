using System.Collections.Generic;
using System.Linq;

namespace LoTLibrary
{
    public static partial class ValidationHelper
    {
        /// <summary>
        /// 判断集合是否有数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public static bool ExistsData<T>(this IEnumerable<T> list)
        {
            bool b = false;
            if (list != null && list.Count() > 0)
            {
                b = true;
            }
            return b;
        }

        /// <summary>
        /// 判断是否为空或Null
        /// </summary>
        /// <param name="objStr"></param>
        /// <returns></returns>
        public static bool IsNullOrWhiteSpace(this string objStr)
        {
            if (string.IsNullOrWhiteSpace(objStr))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
