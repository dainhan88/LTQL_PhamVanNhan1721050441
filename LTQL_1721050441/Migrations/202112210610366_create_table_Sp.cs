namespace LTQL_1721050441.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_Sp : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PVNSanPham441",
                c => new
                    {
                        MaSanPham = c.String(nullable: false, maxLength: 20),
                        TenSanPham = c.String(maxLength: 50),
                        MaNhaCungCap = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaSanPham)
                .ForeignKey("dbo.NhaCungCap441", t => t.MaNhaCungCap, cascadeDelete: true)
                .Index(t => t.MaNhaCungCap);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PVNSanPham441", "MaNhaCungCap", "dbo.NhaCungCap441");
            DropIndex("dbo.PVNSanPham441", new[] { "MaNhaCungCap" });
            DropTable("dbo.PVNSanPham441");
        }
    }
}
