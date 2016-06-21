namespace _AutoMapper
{
    /// <summary>
    /// 7个字段
    /// </summary>
    public partial class NoteViewModel
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 作者
        /// </summary>
        public string Author { get; set; }
        /// <summary>
        /// 浏览次数
        /// </summary>
        public int HitCount { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public string CreateTime { get; set; }
        /// <summary>
        /// 更新时间
        /// </summary>
        public string UpdateTime { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public StatusEnum DataStatus { get; set; }
        /// <summary>
        /// 测试字段
        /// </summary>
        public string Test { get; set; }
    }
}
