namespace WebBanThuoc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatedDataabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tb_Category",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ten = c.String(nullable: false, maxLength: 150),
                        KiHieu = c.String(),
                        MoTa = c.String(),
                        SeoTen = c.String(maxLength: 150),
                        SeoMoTa = c.String(maxLength: 250),
                        SeoKey = c.String(maxLength: 150),
                        TrangThai = c.Boolean(nullable: false),
                        ThuTu = c.Int(nullable: false),
                        NguoiTao = c.String(),
                        NgayTao = c.DateTime(nullable: false),
                        NgaySua = c.DateTime(nullable: false),
                        NguoiSua = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tb_OrderDetail",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        Gia = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tb_Order", t => t.OrderId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.OrderId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.tb_Order",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false),
                        TenKhachHang = c.String(nullable: false),
                        Phone = c.String(nullable: false),
                        DiaChi = c.String(nullable: false),
                        Email = c.String(),
                        TotalAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Quantity = c.Int(nullable: false),
                        TypePayment = c.Int(nullable: false),
                        NguoiTao = c.String(),
                        NgayTao = c.DateTime(nullable: false),
                        NgaySua = c.DateTime(nullable: false),
                        NguoiSua = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ten = c.String(nullable: false, maxLength: 250),
                        KiHieu = c.String(maxLength: 250),
                        MaSanPham = c.String(maxLength: 50),
                        MoTa = c.String(),
                        ChiTiet = c.String(),
                        Image = c.String(maxLength: 250),
                        GiaGoc = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Gia = c.Decimal(nullable: false, precision: 18, scale: 2),
                        GiaSale = c.Decimal(precision: 18, scale: 2),
                        Quantity = c.Int(nullable: false),
                        IsHome = c.Boolean(nullable: false),
                        IsSale = c.Boolean(nullable: false),
                        IsFeature = c.Boolean(nullable: false),
                        IsHot = c.Boolean(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        ProductCategoryId = c.Int(nullable: false),
                        SeoTen = c.String(maxLength: 250),
                        SeoMoTa = c.String(maxLength: 500),
                        SeoKey = c.String(maxLength: 250),
                        NguoiTao = c.String(),
                        NgayTao = c.DateTime(nullable: false),
                        NgaySua = c.DateTime(nullable: false),
                        NguoiSua = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tb_ProductCategory", t => t.ProductCategoryId, cascadeDelete: true)
                .Index(t => t.ProductCategoryId);
            
            CreateTable(
                "dbo.tb_ProductCategory",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ten = c.String(nullable: false, maxLength: 150),
                        KiHieu = c.String(nullable: false, maxLength: 150),
                        MoTa = c.String(),
                        Icon = c.String(maxLength: 250),
                        SeoTen = c.String(maxLength: 250),
                        SeoMoTa = c.String(maxLength: 500),
                        SeoKey = c.String(maxLength: 250),
                        NguoiTao = c.String(),
                        NgayTao = c.DateTime(nullable: false),
                        NgaySua = c.DateTime(nullable: false),
                        NguoiSua = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tb_ProductImage",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        Image = c.String(),
                        IsDefault = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
            AddColumn("dbo.AspNetUsers", "FullName", c => c.String());
            AddColumn("dbo.AspNetUsers", "Phone", c => c.String());
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tb_ProductImage", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Products", "ProductCategoryId", "dbo.tb_ProductCategory");
            DropForeignKey("dbo.tb_OrderDetail", "ProductId", "dbo.Products");
            DropForeignKey("dbo.tb_OrderDetail", "OrderId", "dbo.tb_Order");
            DropIndex("dbo.tb_ProductImage", new[] { "ProductId" });
            DropIndex("dbo.Products", new[] { "ProductCategoryId" });
            DropIndex("dbo.tb_OrderDetail", new[] { "ProductId" });
            DropIndex("dbo.tb_OrderDetail", new[] { "OrderId" });
            DropColumn("dbo.AspNetUsers", "Phone");
            DropColumn("dbo.AspNetUsers", "FullName");
            DropTable("dbo.tb_ProductImage");
            DropTable("dbo.tb_ProductCategory");
            DropTable("dbo.Products");
            DropTable("dbo.tb_Order");
            DropTable("dbo.tb_OrderDetail");
            DropTable("dbo.tb_Category");
        }
    }
}
