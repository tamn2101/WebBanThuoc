namespace WebBanThuoc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatedTableNew : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tb_News",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ten = c.String(nullable: false, maxLength: 150),
                        KiHieu = c.String(),
                        MoTa = c.String(),
                        ChiTiet = c.String(),
                        Image = c.String(),
                        CategoryId = c.Int(nullable: false),
                        SeoTen = c.String(),
                        SeoMoTa = c.String(),
                        SeoKey = c.String(),
                        TrangThai = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tb_Category", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.tb_Posts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ten = c.String(nullable: false, maxLength: 150),
                        KiHieu = c.String(maxLength: 150),
                        MoTa = c.String(),
                        ChiTiet = c.String(),
                        Image = c.String(maxLength: 250),
                        CategoryId = c.Int(nullable: false),
                        SeoTen = c.String(maxLength: 250),
                        SeoMoTa = c.String(maxLength: 500),
                        SeoKey = c.String(maxLength: 250),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tb_Category", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tb_Posts", "CategoryId", "dbo.tb_Category");
            DropForeignKey("dbo.tb_News", "CategoryId", "dbo.tb_Category");
            DropIndex("dbo.tb_Posts", new[] { "CategoryId" });
            DropIndex("dbo.tb_News", new[] { "CategoryId" });
            DropTable("dbo.tb_Posts");
            DropTable("dbo.tb_News");
        }
    }
}
