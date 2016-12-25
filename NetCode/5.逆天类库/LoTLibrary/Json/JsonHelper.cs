using Newtonsoft.Json;
using System.Threading.Tasks;

public static partial class JsonHelper
{
    #region 同步方法
    /// <summary>
    /// Model转换成Json
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public static string ObjectToJson(this object obj)
    {
        return JsonConvert.SerializeObject(obj);
    }
    /// <summary>
    /// Json转换成Model
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="str"></param>
    /// <returns></returns>
    public static T JsonToModels<T>(this string str)
    {
        return JsonConvert.DeserializeObject<T>(str);
    }
    #endregion

    #region 异步方法
    /// <summary>
    /// Model转换成Json
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public static async Task<string> ObjectToJsonAsync(this object obj)
    {
        return await Task.Factory.StartNew(() => JsonConvert.SerializeObject(obj));
    }
    /// <summary>
    /// Json转换成Model（异步方法）
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="obj"></param>
    /// <returns></returns>
    public static async Task<T> JsonToModelsAsync<T>(this string str)
    {
        return await Task.Factory.StartNew(() => JsonConvert.DeserializeObject<T>(str));
    }
    #endregion
}