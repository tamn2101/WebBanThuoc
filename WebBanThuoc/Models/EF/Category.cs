using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebBanThuoc.Models.EF
{

    [Table("tb_Category")]
    public class Category : CommonAbstract
    {
        public Category()
        {
            this.News = new HashSet<News>();
        }

        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên danh mục không để trống")]
        [StringLength(150)]
        public string Ten { get; set; }
        public string KiHieu { get; set; }
        public string MoTa { get; set; }
        public string Link { get; set; }

        [StringLength(150)]
        public string SeoTen { get; set; }// seo tu khoa cho google
        [StringLength(250)]
        public string SeoMoTa { get; set; }
        [StringLength(150)]
        public string SeoKey { get; set; }
        public bool TrangThai { get; set; }
        public int ThuTu { get; set; }
        public ICollection<News> News { get; set; }
        public ICollection<Posts> Posts { get; set; }


        //[Key]
        //[DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        //public int Id { get; set; }
        //[Required(ErrorMessage = "Tên danh mục không để trống")]
        //[StringLength(150)]
        //public string Title { get; set; }
        //public string Alias { get; set; }
        ////[StringLength(150)]
        ////public string TypeCode { get; set; }
        //public string Link { get; set; }
        //public string Description { get; set; }

        //[StringLength(150)]
        //public string SeoTitle { get; set; }// seo tu khoa cho google
        //[StringLength(250)]
        //public string SeoDescription { get; set; }
        //[StringLength(150)]
        //public string SeoKeywords { get; set; }
        //public bool IsActive { get; set; }
        //public int Position { get; set; }
    }
}