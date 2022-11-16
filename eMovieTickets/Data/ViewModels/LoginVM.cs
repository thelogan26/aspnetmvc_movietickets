using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eMovieTickets.Data.ViewModels
{
    public class LoginVM
    {
        [Display(Name = "Địa chỉ email")]
        [Required(ErrorMessage = "Yêu cầu nhập email")]
        public string EmailAddress { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
