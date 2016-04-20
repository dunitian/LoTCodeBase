using System;
using Newtonsoft.Json;

namespace _01.Json系列
{
    public static class JsonHelper
    {
        /// <summary>
        ///把指定类型转换为Json
        /// </summary>
        /// <param name="list">集合</param>
        /// <returns></returns>
        public static string ObjectToJson(this object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        /// <summary>
        /// 把Json转换为指定T
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="jsonStr"></param>
        /// <returns></returns>
        public static T JsonToModels<T>(this string jsonStr)
        {
            return JsonConvert.DeserializeObject<T>(jsonStr);
        }
    }
}
