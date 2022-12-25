using Books.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Books.Data.ViewModels
{
    public class NewBookVM
    {
        public int Id { get; set; }

        [Display(Name = "Tên sách")]
        [Required(ErrorMessage = "Không được để trống")]
        public string Name { get; set; }

        [Display(Name = "Tên tác giả")]
        [Required(ErrorMessage = "Không được để trống")]
        public string Author { get; set; }

        [Display(Name = "Mô tả")]
        [Required(ErrorMessage = "Không được để trống")]
        public string Description { get; set; }

        [Display(Name = "Giá bán")]
        [Required(ErrorMessage = "Không được để trống")]
        public double Price { get; set; }

        [Display(Name = "Số lượng")]
        [Required(ErrorMessage = "Không được để trống và phải lớn hơn 0")]
        public uint Count { get; set; }

        [Display(Name = "Số trang")]
        [Required(ErrorMessage = "Không được để trống")]
        public int PageNumber { get; set; }

        [Display(Name = "URL hình ảnh")]
        [Required(ErrorMessage = "Không được để trống")]
        public string ImageURL { get; set; }

        [Display(Name = "Ngày phát hành")]
        [Required(ErrorMessage = "Không được để trống")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Thê loại")]
        [Required(ErrorMessage = "Không được để trống")]
        public BookCategory BookType { get; set; }

        public string Comment { get; set; }
        public List<Rattings> ListOfComments { get; set; }
        public int Star { get; set; }
    }
}
