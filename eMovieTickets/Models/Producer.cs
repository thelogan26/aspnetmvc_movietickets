using eMovieTickets.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eMovieTickets.Models
{
    public class Producer: IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Hình ảnh")]
        [Required(ErrorMessage = "Yêu cầu nhập liên kết hình ảnh")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Họ tên")]
        [Required(ErrorMessage = "Yêu cầu nhập tên nhà sản xuất")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Vui lòng nhập tên phù hợp.")]
        public string FullName { get; set; }
        [Display(Name = "Tiểu sử")]
        [Required(ErrorMessage = "Yêu cầu nhập tiểu sử")]
        public string Bio { get; set; }

        // Relationships
        public List<Movie> Movies { get; set; }
    }
}
