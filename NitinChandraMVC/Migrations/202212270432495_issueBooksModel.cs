namespace NitinChandraMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class issueBooksModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.IssueBooks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StdId = c.Int(nullable: false),
                        StdName = c.String(nullable: false),
                        IssueDate = c.DateTime(nullable: false),
                        ReturnDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.IssueBooks");
        }
    }
}
