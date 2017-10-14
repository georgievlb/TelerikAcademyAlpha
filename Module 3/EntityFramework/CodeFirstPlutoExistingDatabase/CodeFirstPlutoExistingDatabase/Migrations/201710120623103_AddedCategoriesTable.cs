namespace CodeFirstPlutoExistingDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCategoriesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: false),//id column by convention is an identity column, if we want to overwrite this we set it to false
                        Name = c.String(),                             //thus we have to specify both name and Id for each column
                    })
                .PrimaryKey(t => t.Id);

            Sql("INSERT INTO Categories VALUES (1, 'Web Development')");//run any SQL statements on your DB
            Sql("INSERT INTO Categories VALUES (2, 'Programming Languages')");
        }
        
        public override void Down()
        {
            DropTable("dbo.Categories");
        }
    }
}
