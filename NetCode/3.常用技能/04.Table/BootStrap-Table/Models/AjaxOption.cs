namespace BootStrap_Table.Models
{
    public partial class AjaxOption<T> where T : class
    {
        /// <summary>
        /// 状态（是否成功）
        /// </summary>
        public bool Status { get; set; }
        /// <summary>
        /// 响应消息
        /// </summary>
        public string Msg { get; set; }
        /// <summary>
        /// 响应数据
        /// </summary>
        public T Data { get; set; }
        /// <summary>
        /// 通用数据
        /// </summary>
        public object OtherData { get; set; }
        /// <summary>
        /// 构造函数初始化
        /// </summary>
        public AjaxOption()
        {
            Status = false;
            Msg = string.Empty;
            Data = default(T);
            OtherData = null;
        }
    }
}