using eMovieTickets.Data;
using eMovieTickets.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eMovieTickets.Models
{
    public class NewMovieVM
    {
        public int Id { get; set; }

        [Display(Name = "Tên phim")]
        [Required(ErrorMessage ="Yêu cầu nhập tên")]
        public string Name { get; set; }
        [Display(Name = "Mô tả")]
        [Required(ErrorMessage = "Yêu cầu nhập mô tả")]
        public string Description { get; set; }
        [Display(Name = "Giá ($)")]
        [Required(ErrorMessage = "Yêu cầu nhập giá")]
        public double Price { get; set; }
        [Display(Name = "Liên kết ảnh")]
        [Required(ErrorMessage = "Yêu cầu nhập liên kết ảnh")]
        public string ImageURL { get; set; }
        [Display(Name = "Ngày bắt đầu")]
        [Required(ErrorMessage = "Yêu cầu nhập ngày bắt đầu")]
        public DateTime StartDate { get; set; }
        [Display(Name = "Ngày kết thúc")]
        [Required(ErrorMessage = "Yêu cầu nhập Ngày kết thúc")]
        public DateTime EndDate { get; set; }
        [Display(Name = "Thể loại")]
        [Required(ErrorMessage = "Yêu cầu chọn thể loại")]
        public MovieCategory MovieCategory { get; set; }

        // Relationships
        [Display(Name = "Chọn các diễn viên")]
        [Required(ErrorMessage = "Yêu cầu chọn các diễn viên")]
        public List<int> ActorIds { get; set; }
        [Display(Name = "Chọn rạp chiếu phim")]
        [Required(ErrorMessage = "Yêu cầu chọn rạp chiếu phim")]
        public int CinemaId { get; set; }
        [Display(Name = "Chọn nhà sản xuất")]
        [Required(ErrorMessage = "Yêu cầu chọn nhà sản xuất")]
        public int ProducerId { get; set; }
        
    }
}
