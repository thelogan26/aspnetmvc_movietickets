using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eMovieTickets.Data.ViewModels
{
    public class RegisterVM
    {
        [Display(Name = "Họ tên")]
        [Required(ErrorMessage = "Yêu cầu nhập họ tên")]
        public string FullName { get; set; }

        [Display(Name = "Tên người dùng")]
        [Required(ErrorMessage = "Yêu cầu nhập tên người dùng")]
        public string UserName { get; set; }

        [Display(Name = "Số điện thoại")]
        public string Phone { get; set; }
        [Display(Name = "Địa chỉ")]
        public string Address { get; set; }

        [Display(Name = "Địa chỉ email")]
        [Required(ErrorMessage = "Yêu cầu nhập email")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Yêu cầu nhập mật khẩu")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Xác nhận mật khẩu")]
        [Required(ErrorMessage = "Yêu cầu nhập xác nhận mật khẩu")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Xác nhận khẩu sai")]
        public string ConfirmPassword { get; set; }
    }
}
