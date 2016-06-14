using System.Collections.Generic;

namespace BootStrap_Table.Models
{
    /// <summary>
    /// “字段”的命名规范应该首字母大写，但Bootstrap-Table不认识，为了避免二次处理就首字母小写了
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public partial class PageData<T>
    {
        /// <summary>
        /// 总页数
        /// </summary>
        public int total { get; set; }
        /// <summary>
        /// 查询的数据
        /// </summary>
        public IEnumerable<T> rows { get; set; }
    }
}