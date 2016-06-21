namespace _AutoMapper
{
    /// <summary>
    /// SeoTKD表
    /// </summary>
    public partial class SeoTKD
    {
        public int Id { get; set; }

        /// <summary>
        /// SEO关键词（，分隔 149字以内）
        /// </summary>
        public string SeoKeywords { get; set; }

        /// <summary>
        /// SEO内容（249字以内）
        /// </summary>
        public string Seodescription { get; set; }

        /// <summary>
        /// 状态（99为删除）
        /// </summary>
        public StatusEnum DataStatus { get; set; }
    }
}
