namespace NitinChandraMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialFirst : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        BookId = c.Int(nullable: false, identity: true),
                        Book_Name = c.String(nullable: false),
                        Author_Name = c.String(nullable: false),
                        Book_Price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BookId);
            
            CreateTable(
                "dbo.UserModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        Mobile = c.String(nullable: false),
                        Role = c.String(nullable: false),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserModels");
            DropTable("dbo.Books");
        }
    }
}
