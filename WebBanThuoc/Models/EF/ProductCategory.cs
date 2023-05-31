using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebBanThuoc.Models.EF
{
    [Table("tb_ProductCategory")]
    public class ProductCategory: CommonAbstract
    {
        public ProductCategory()
        {
            this.Products = new HashSet<Product>();
        }
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(150)]
        public string Ten { get; set; }
        [Required]
        [StringLength(150)]
        public string  KiHieu{ get; set; }
        //Alias
        public string MoTa { get; set; }
        [StringLength(250)]
        public string Icon { get; set; }
        [StringLength(250)]
        public string SeoTen { get; set; }
        [StringLength(500)]
        public string SeoMoTa { get; set; }
        [StringLength(250)]
        public string SeoKey { get; set; }

        public ICollection<Product> Products { get; set; }
    
    }
}