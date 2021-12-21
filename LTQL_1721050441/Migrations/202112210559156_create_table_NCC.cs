namespace LTQL_1721050441.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_NCC : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NhaCungCap441",
                c => new
                    {
                        MaNhaCungCap = c.Int(nullable: false, identity: true),
                        TenNhaCungCap = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.MaNhaCungCap);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NhaCungCap441");
        }
    }
}
