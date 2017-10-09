namespace CodeFirstDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addmigrationCreatePost : DbMigration
    {
        public override void Up() //upgrade database
        {
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DatePublished = c.DateTime(nullable: false),
                        Title = c.String(),
                        Body = c.String(),
                    })
                .PrimaryKey(t => t.Id);//EF uses convention over configuration - based on name and type of proerties it can figure out how the DB should look like e.g. ID = primary key and = identity column
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Posts"); //downgrade database
        }
    }
}
