using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Books.Data.ViewModels
{
    public class RegisterVM
    {
        [Display(Name = "Full name")]
        [Required(ErrorMessage = "Không được để trống")]
        public string FullName { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Không được để trống")]
        public string EmailAddress { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "xác nhận lại mật khẩu")]
        [Required(ErrorMessage = "Không được để trống")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Không đúng với mật khẩu ở trên")]
        public string ConfirmPassword { get; set; }
    }
}
