using System.Collections.Generic;
using System.Linq;

public static partial class FunHelper
{
    /// <summary>  
    /// 判断字符串input 在 input字符串中出现的次数(递归调用)
    /// </summary>  
    /// <param name="objStr">源字符串</param>  
    /// <param name="input">用于比较的字符串</param>  
    /// <returns>字符串compare 在 input字符串中出现的次数</returns>  
    public static int GetStrCount(this string objStr, string input)
    {
        int index = objStr.IndexOf(input);
        if (index != -1)
        {
            return 1 + GetStrCount(objStr.Substring(index + input.Length), input);
        }
        else
        {
            return 0;
        }
    }

    /// <summary>
    /// 获取第一个元素（已验证）有数据则返回第一个，没数据则返回默认
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="list"></param>
    /// <returns></returns>
    public static T GetFirstOrDefault<T>(this IEnumerable<T> list)
    {
        if (list.ExistsData())
        {
            return list.FirstOrDefault();
        }
        return default(T);
    }
}
