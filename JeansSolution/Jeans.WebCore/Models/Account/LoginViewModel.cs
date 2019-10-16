using System.ComponentModel.DataAnnotations;

namespace Jeans.WebCore.Models.Account
{
    public class LoginViewModel
    {
        [Display(Name = "用户名")]
        [Required(ErrorMessage = "{0} 必填项.")]
        public string UserName { get; set; }

        [Display(Name = "密码")]
        [Required(ErrorMessage = "{0} 必填项.")]
        public string Password { get; set; }

        public bool HasLogin()
        {
            return UserName == "Jeans" && Password == "Jeans123456";
        }
    }
}
