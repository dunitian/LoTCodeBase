using Microsoft.Win32;
using System.Collections.Generic;

public static partial class RegistryHelper
{
    #region 节点
    /// <summary>
    /// HKEY_LOCAL_MACHINE 节点
    /// </summary>
    public static RegistryKey RootReg = Registry.LocalMachine;

    /// <summary>
    /// HKEY_LOCAL_MACHINE 下 Software 节点
    /// </summary>
    public static RegistryKey SoftReg = Registry.LocalMachine.OpenSubKey("software", true);

    /// <summary>
    /// 包含有关当前用户首选项的信息。该字段读取 Windows 注册表基项 HKEY_CURRENT_USER
    /// </summary>
    public static RegistryKey CurrentUser = Registry.CurrentUser;

    /// <summary>
    /// HKEY_CURRENT_USER 下 Software 节点
    /// </summary>
    public static RegistryKey UserSoftReg = Registry.CurrentUser.OpenSubKey("software", true);
    #endregion

    #region 查询
    /// <summary>
    /// 根据名称查找Key，有则返回RegistryKey对象，没有则返回null
    /// </summary>
    /// <param name="name">要打开的子项的名称或路径</param>
    /// <param name="b">如果不需要写入权限请选择false</param>
    /// <returns></returns>
    public static RegistryKey FindKey(this RegistryKey reg, string name, bool b = true)
    {
        return reg.OpenSubKey(name, b);
    }

    /// <summary>
    /// 获取（name，value）字典，没有则返回null
    /// </summary>
    /// <param name="reg">当前RegistryKey</param>
    /// <returns></returns>
    public static IDictionary<string, object> GetKeyValueDic(this RegistryKey reg)
    {
        var dic = new Dictionary<string, object>();
        if (reg.ValueCount == 0) { return null; }
        ForeachRegKeys(reg, ref dic);
        return dic;
    }

    /// <summary>
    /// 获取子项（name，value）字典，没有则返回null
    /// </summary>
    /// <param name="reg">当前RegistryKey</param>
    /// <returns></returns>
    public static IDictionary<string, object> GetSubKeyValueDic(this RegistryKey reg)
    {
        var dic = new Dictionary<string, object>();
        if (reg.SubKeyCount == 0) { return null; }
        foreach (var item in reg.GetSubKeyNames())
        {
            //以只读方式检索子项
            var sonKey = reg.OpenSubKey(item);
            ForeachRegKeys(sonKey, ref dic);
        }
        return dic;
    }

    /// <summary>
    /// 遍历RegistryKey
    /// </summary>
    /// <param name="reg"></param>
    /// <param name="dic"></param>
    private static void ForeachRegKeys(RegistryKey reg, ref Dictionary<string, object> dic)
    {
        foreach (var name in reg.GetValueNames())
        {
            dic.Add(name, reg.GetValue(name));
        }
    }
    #endregion

    #region 添加
    /// <summary>
    /// 添加一个子项
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public static RegistryKey AddSubItem(this RegistryKey reg, string name)
    {
        return reg.CreateSubKey(name);
    }

    /// <summary>
    /// 添加key-value，异常则RegistryKey对象返回null
    /// </summary>
    /// <param name="reg"></param>
    /// <param name="key"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    public static RegistryKey AddKeyValue(this RegistryKey reg, string key, object value)
    {
        reg.SetValue(key, value);
        return reg;
    }
    #endregion

    #region 修改
    /// <summary>
    /// 修改key-value，异常则RegistryKey对象返回null
    /// </summary>
    /// <param name="reg"></param>
    /// <param name="key"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    public static RegistryKey UpdateKeyValue(this RegistryKey reg, string key, object value)
    {
        return reg.AddKeyValue(key, value);
    }
    #endregion

    #region 删除
    /// <summary>
    /// 根据Key删除项
    /// </summary>
    /// <param name="reg"></param>
    /// <param name="key"></param>
    /// <returns></returns>
    public static RegistryKey DeleteKeyValue(this RegistryKey reg, string key)
    {
        reg.DeleteValue(key, false);
        return reg;
    }

    /// <summary>
    /// 删除子项所有内容
    /// </summary>
    /// <param name="reg"></param>
    /// <param name="key"></param>
    /// <returns></returns>
    public static RegistryKey ClearSubAll(this RegistryKey reg, string key)
    {
        reg.DeleteSubKeyTree(key, false);
        return reg;
    }
    #endregion
}
