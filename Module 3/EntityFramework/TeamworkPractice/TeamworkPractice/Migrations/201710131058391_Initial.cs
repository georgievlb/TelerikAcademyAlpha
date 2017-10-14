namespace TeamworkPractice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Books", new[] { "Languages_Id" });
            RenameColumn(table: "dbo.Languages", name: "Languages_Id", newName: "Book_Id");
            CreateIndex("dbo.Languages", "Book_Id");
            DropColumn("dbo.Books", "Languages_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "Languages_Id", c => c.Int());
            DropIndex("dbo.Languages", new[] { "Book_Id" });
            RenameColumn(table: "dbo.Languages", name: "Book_Id", newName: "Languages_Id");
            CreateIndex("dbo.Books", "Languages_Id");
        }
    }
}
