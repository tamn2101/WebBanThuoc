using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebBanThuoc.Models.EF
{
    public class Product: CommonAbstract
    {
        public Product()
        {
            this.ProductImage = new HashSet<ProductImage>();
            this.OrderDetails = new HashSet<OrderDetail>();
        }
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(250)]
        public string Ten { get; set; }

        [StringLength(250)]
        public string KiHieu { get; set; }

        [StringLength(50)]
        public string MaSanPham { get; set; }
        public string MoTa { get; set; }

        [AllowHtml]
        public string ChiTiet { get; set; }

        [StringLength(250)]
        public string Image { get; set; }
        public decimal GiaGoc { get; set; }
        //OriginalPrice
        public decimal Gia { get; set; }
        public decimal? GiaSale { get; set; }
        public int Quantity { get; set; }
        //public int ViewCount { get; set; }
        public bool IsHome { get; set; }
        public bool IsSale { get; set; }
        public bool IsFeature { get; set; }
        public bool IsHot { get; set; }
        public bool IsActive { get; set; }
        public int ProductCategoryId { get; set; }

        [StringLength(250)]
        public string SeoTen { get; set; }
        [StringLength(500)]
        public string SeoMoTa { get; set; }
        [StringLength(250)]
        public string SeoKey { get; set; }

        public virtual ProductCategory ProductCategory { get; set; }
        public virtual ICollection<ProductImage> ProductImage { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}