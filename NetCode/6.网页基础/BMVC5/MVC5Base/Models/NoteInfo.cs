namespace MVC5Base.Models
{
    public class NoteInfo
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int NId { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        public string NTitle { get; set; }
        /// <summary>
        /// 内容
        /// </summary>
        public string NContent { get; set; }
        /// <summary>
        /// 作者
        /// </summary>
        public string NAuthor { get; set; }
        /// <summary>
        /// 浏览次数
        /// </summary>
        public int NHitCount { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public long NCreateTime { get; set; }
        /// <summary>
        /// 更新时间
        /// </summary>
        public long NUpdateTime { get; set; }
        /// <summary>
        /// 文章展图
        /// </summary>
        public string NDisplayPic { get; set; }
        /// <summary>
        /// 是否推送到主页
        /// </summary>
        public bool NPush { get; set; }
        /// <summary>
        /// SEO外键ID
        /// </summary>
        public int NSeoId { get; set; }
    }
}