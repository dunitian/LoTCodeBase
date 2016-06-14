/// <summary>
/// 修改下命名空间，免得每次用都得引用命名空间
/// </summary>
namespace BootStrap_Table
{
    /// <summary>
    /// 状态类型
    /// </summary>
    public enum StatusEnum
    {
        /// <summary>
        /// 初始的
        /// </summary>
        Init,
        /// <summary>
        /// 正常的
        /// </summary>
        Normal,
        /// <summary>
        /// 已删除
        /// </summary>
        Deteled = 99
    }
}
