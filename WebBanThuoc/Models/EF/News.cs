using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebBanThuoc.Models.EF
{
    [Table("tb_News")]
    public class News
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Bạn không để trống tiêu đề tin")]
        [StringLength(150)]
        public string Ten { get; set; }
        public string KiHieu { get; set; }
        public string MoTa { get; set; }
        [AllowHtml]
        public string ChiTiet { get; set; }
        public string Image { get; set; }
        public int CategoryId { get; set; }
        public string SeoTen { get; set; }
        public string SeoMoTa{ get; set; }
        public string SeoKey{ get; set; }
        public bool TrangThai { get; set; }
        public virtual Category Category { get; set; }
    }
}