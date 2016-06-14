using System.Collections.Generic;
using System.Linq;

namespace BootStrap_Table
{
    /// <summary>
    /// 公共方法
    /// </summary>
    public static partial class PubFunc
    {
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

        /// <summary>
        /// 判断集合是否有数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public static bool ExistsData<T>(IEnumerable<T> list)
        {
            bool b = false;
            if (list != null && list.Count() > 0)
            {
                b = true;
            }
            return b;
        }

    }
}