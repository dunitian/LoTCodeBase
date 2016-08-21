using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVC5Base.Models
{
    public partial class Register
    {
        /// <summary>
        /// Guid
        /// </summary>
        public Guid GId { get; set; }

        /// <summary>
        /// 真实年龄
        /// </summary>
        [Range(18, 120)]
        [Display(Name = "真实年龄：")]
        public int Age { get; set; }

        /// <summary>
        /// 贡献金额
        /// </summary>
        [Display(Name = "贡献金额：")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:c}")]
        [Range(typeof(decimal), "0.00", "49.99")]
        public decimal Money { get; set; }

        /// <summary>
        /// 网络昵称
        /// </summary>
        [Required]
        [Display(Name = "网络昵称：")]
        [StringLength(50, MinimumLength = 3)]
        [System.Web.Mvc.Remote("CheckName", "Model")]
        public string NiName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        [Required]
        [Display(Name = "输入密码：")]
        [DataType(DataType.Password)]
        [StringLength(32, MinimumLength = 6)]
        public string Pass { get; set; }

        /// <summary>
        /// 确认密码
        /// </summary>
        [Required]
        [Compare("Pass")]
        [Display(Name = "确认密码：")]
        [DataType(DataType.Password)]
        public string RPass { get; set; }

        /// <summary>
        /// 注册邮箱
        /// </summary>
        [Required]
        [Display(Name = "注册邮箱：")]
        [System.Web.Mvc.Remote("CheckEmail", "Model")]
        [RegularExpression(@"/^(\w)+(\.\w+)*@(\w)+((\.\w{2,3}){1,3})$/",ErrorMessage ="邮箱格式不正确")]
        public string Email { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public long CreateTime { get; set; }

        /// <summary>
        /// 数据状态（一般都是枚举类型）
        /// </summary>
        public int DataStatus { get; set; }

        [ReadOnly(true)]
        [System.Web.Mvc.HiddenInput]
        public string Test { get; set; }
    }
}