
namespace _01.Json系列
{
    /// <summary>
    /// 菜单
    /// </summary>
    public class ShopMenu
    {
        /// <summary>
        /// 菜名
        /// </summary>
        public string MName { get; set; }
        /// <summary>
        /// 菜价格
        /// </summary>
        public string MPrice { get; set; }
        /// <summary>
        /// 类别：大荤，小荤，谷物，蔬菜，水果，零食等
        /// </summary>
        public string MType { get; set; }
        /// <summary>
        /// 市
        /// </summary>
        public string CPName { get; set; }
        /// <summary>
        /// 区
        /// </summary>
        public string CName { get; set; }
        /// <summary>
        /// 超市名
        /// </summary>
        public string SName { get; set; }
    }
}