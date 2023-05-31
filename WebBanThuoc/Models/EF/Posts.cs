using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebBanThuoc.Models.EF
{
    [Table("tb_Posts")]
    public class Posts
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(150)]
        public string Ten { get; set; }

        [StringLength(150)]
        public string KiHieu { get; set; }
        public string MoTa { get; set; }

        [AllowHtml]
        public string ChiTiet { get; set; }

        [StringLength(250)]
        public string Image { get; set; }
        public int CategoryId { get; set; }

        [StringLength(250)]
        public string SeoTen{ get; set; }
        [StringLength(500)]
        public string SeoMoTa { get; set; }
        [StringLength(250)]
        public string SeoKey{ get; set; }
        public bool IsActive { get; set; }
        public virtual Category Category { get; set; }
    }
}