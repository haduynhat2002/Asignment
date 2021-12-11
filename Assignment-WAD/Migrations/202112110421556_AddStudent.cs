namespace Assignment_WAD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStudent : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MaSinhVien = c.Int(nullable: false),
                        HinhThucNopPhat = c.Int(nullable: false),
                        SoTienNopPhat = c.String(),
                        NgayNopPhat = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
        }
    }
}
