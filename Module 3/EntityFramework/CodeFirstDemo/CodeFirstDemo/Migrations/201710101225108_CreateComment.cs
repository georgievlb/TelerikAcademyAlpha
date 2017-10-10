namespace CodeFirstDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateComment : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DatePublished = c.DateTime(nullable: false),
                        Title = c.String(),
                        Body = c.String(),
                        post_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Posts", t => t.post_Id)
                .Index(t => t.post_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comments", "post_Id", "dbo.Posts");
            DropIndex("dbo.Comments", new[] { "post_Id" });
            DropTable("dbo.Comments");
        }
    }
}
