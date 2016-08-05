using System.ComponentModel.DataAnnotations;

namespace MVC5Base.Models
{
    public partial class UserInfo
    {
        [Display(Name = "用户名")]
        [Required(ErrorMessage ="用户名不能为空")]
        public string Name { get; set; }

        [Display(Name = "密  码")]
        [Required(ErrorMessage ="密码不能为空")]
        public string Pass { get; set; }

    }
}