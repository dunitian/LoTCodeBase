using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public static partial class ValidationHelper
{
    #region 常用验证

    #region 集合系列
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
    #endregion

    #region Null判断系列
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
    /// 判断类型是否为可空类型
    /// </summary>
    /// <param name="theType"></param>
    /// <returns></returns>
    public static bool IsNullableType(Type theType)
    {
        return (theType.IsGenericType && theType.GetGenericTypeDefinition().Equals(typeof(Nullable<>)));
    }
    #endregion

    #region 数字字符串检查
    /// <summary>
    /// 是否数字字符串(包括小数)
    /// </summary>
    /// <param name="objStr">输入字符串</param>
    /// <returns></returns>
    public static bool IsNumber(this string objStr)
    {
        try
        {
            return Regex.IsMatch(objStr, @"^\d+(\.\d+)?$");
        }
        catch
        {
            return false;
        }
    }

    /// <summary>
    /// 是否是浮点数
    /// </summary>
    /// <param name="inputData">输入字符串</param>
    /// <returns></returns>
    public static bool IsDecimal(string strIn)
    {
        try
        {
            return Regex.IsMatch(strIn, @"^(-?\d+)(\.\d+)?$");
        }
        catch
        {
            return false;
        }
    }
    #endregion

    #endregion

    #region 业务常用

    #region 中文检测
    /// <summary>
    /// 检测是否有中文字符
    /// </summary>
    /// <param name="inputData"></param>
    /// <returns></returns>
    public static bool IsZhCN(this string objStr)
    {
        try
        {
            return Regex.IsMatch(objStr, "[\u4e00-\u9fa5]");
        }
        catch
        {
            return false;
        }
    }
    #endregion

    #region 邮箱验证
    /// <summary>
    /// 判断邮箱地址是否正确
    /// </summary>
    /// <param name="objStr"></param>
    /// <returns></returns>
    public static bool IsValidEmail(this string objStr)
    {
        try
        {
            return Regex.IsMatch(objStr, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }
        catch
        {
            return false;
        }
    }
    #endregion

    #region IP系列验证
    /// <summary>
    /// 是否为ip
    /// </summary>
    /// <param name="ip"></param>
    /// <returns></returns>
    public static bool IsIP(string ip)
    {
        return Regex.IsMatch(ip, @"^((2[0-4]\d|25[0-5]|[01]?\d\d?)\.){3}(2[0-4]\d|25[0-5]|[01]?\d\d?)$");
    }

    /// <summary>  
    /// 判断输入的字符串是否是表示一个IP地址  
    /// </summary>  
    /// <param name="input">被比较的字符串</param>  
    /// <returns>是IP地址则为True</returns>  
    public static bool IsIPv4(string input)
    {
        string[] IPs = input.Split('.');
        for (int i = 0; i < IPs.Length; i++)
        {
            if (!Regex.IsMatch(IPs[i], @"^\d+$"))
            {
                return false;
            }
            if (Convert.ToUInt16(IPs[i]) > 255)
            {
                return false;
            }
        }
        return true;
    }

    /// <summary>
    /// 判断输入的字符串是否是合法的IPV6 地址  
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static bool IsIPV6(string input)
    {
        string temp = input;
        string[] strs = temp.Split(':');
        if (strs.Length > 8)
        {
            return false;
        }
        int count = input.GetStrCount("::");
        if (count > 1)
        {
            return false;
        }
        else if (count == 0)
        {
            return Regex.IsMatch(input, @"^([\da-f]{1,4}:){7}[\da-f]{1,4}$");
        }
        else
        {
            return Regex.IsMatch(input, @"^([\da-f]{1,4}:){0,5}::([\da-f]{1,4}:){0,5}[\da-f]{1,4}$");
        }
    }
    #endregion

    #region 网址系列验证
    /// <summary>
    /// 验证网址是否正确（http:或者https:）【后期添加 // 的情况】
    /// </summary>
    /// <param name="objStr">地址</param>
    /// <returns></returns>
    public static bool IsWebUrl(this string objStr)
    {
        try
        {
            return Regex.IsMatch(objStr, @"http://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?|https://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?");
        }
        catch
        {
            return false;
        }
    }

    /// <summary>
    /// 判断输入的字符串是否是一个超链接  
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static bool IsURL(string input)
    {
        string pattern = @"^[a-zA-Z]+://(\w+(-\w+)*)(\.(\w+(-\w+)*))*(\?\S*)?$";
        return Regex.IsMatch(input, pattern);
    }
    #endregion

    #region 邮政编码验证
    /// <summary>
    /// 验证邮政编码是否正确
    /// </summary>
    /// <param name="objStr">输入字符串</param>
    /// <returns></returns>
    public static bool IsZipCode(this string objStr)
    {
        try
        {
            return Regex.IsMatch(objStr, @"\d{6}");
        }
        catch
        {
            return false;
        }
    }
    #endregion

    #region 电话+手机验证
    /// <summary>
    /// 验证手机号是否正确
    /// </summary>
    /// <param name="objStr">手机号</param>
    /// <returns></returns>
    public static bool IsMobile(this string objStr)
    {
        try
        {
            return Regex.IsMatch(objStr, @"^13[0-9]{9}|15[012356789][0-9]{8}|18[0123456789][0-9]{8}|147[0-9]{8}$");
        }
        catch
        {
            return false;
        }
    }

    /// <summary>
    /// 匹配3位或4位区号的电话号码，其中区号可以用小括号括起来，也可以不用，区号与本地号间可以用连字号或空格间隔，也可以没有间隔   
    /// </summary>
    /// <param name="objStr"></param>
    /// <returns></returns>
    public static bool IsPhone(this string objStr)
    {
        try
        {
            return Regex.IsMatch(objStr, "^\\(0\\d{2}\\)[- ]?\\d{8}$|^0\\d{2}[- ]?\\d{8}$|^\\(0\\d{3}\\)[- ]?\\d{7}$|^0\\d{3}[- ]?\\d{7}$");
        }
        catch
        {
            return false;
        }
    }
    #endregion

    #region 字母或数字验证
    /// <summary>
    /// 是否只是字母或数字
    /// </summary>
    /// <param name="objStr"></param>
    /// <returns></returns>
    public static bool IsAbcOr123(this string objStr)
    {
        try
        {
            return Regex.IsMatch(objStr, @"^[0-9a-zA-Z\$]+$");
        }
        catch
        {
            return false;
        }
    }
    #endregion

    #endregion
}
