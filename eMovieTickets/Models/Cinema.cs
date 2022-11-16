using eMovieTickets.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eMovieTickets.Models
{
    public class Cinema: IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name="Logo")]
        [Required(ErrorMessage = "Yêu cầu nhập Logo")]
        public string Logo { get; set; }
        [Display(Name = "Tên rạp")]
        [Required(ErrorMessage = "Yêu cầu nhập tên rạp")]
        public string Name { get; set; }
        [Display(Name = "Mô tả")]
        [Required(ErrorMessage = "Yêu cầu nhập mô tả")]
        public string Description { get; set; }

        // Relationships
        public List<Movie> Movies { get; set; }
    }
}
