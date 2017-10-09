namespace CodeFirstPluto.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(//EF uses convention over configuration i.e. columns'their names, types and configuration is based on our model
                "dbo.Authors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        Level = c.Int(nullable: false),
                        FullPrice = c.Single(nullable: false),
                        author_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Authors", t => t.author_Id)
                .Index(t => t.author_Id);
            
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TagCourses",//intermediary table, used in a many-to-many relationships i.e. a course can have many tags and a tag can be applied to multiplec courses EF KNOWS ALL THIS BECAUSE IT WORKS ON CONVENTION
                c => new
                    {
                        Tag_Id = c.Int(nullable: false),
                        Course_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Tag_Id, t.Course_Id })
                .ForeignKey("dbo.Tags", t => t.Tag_Id, cascadeDelete: true)
                .ForeignKey("dbo.Courses", t => t.Course_Id, cascadeDelete: true)
                .Index(t => t.Tag_Id)
                .Index(t => t.Course_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TagCourses", "Course_Id", "dbo.Courses");
            DropForeignKey("dbo.TagCourses", "Tag_Id", "dbo.Tags");
            DropForeignKey("dbo.Courses", "author_Id", "dbo.Authors");
            DropIndex("dbo.TagCourses", new[] { "Course_Id" });
            DropIndex("dbo.TagCourses", new[] { "Tag_Id" });
            DropIndex("dbo.Courses", new[] { "author_Id" });
            DropTable("dbo.TagCourses");
            DropTable("dbo.Tags");
            DropTable("dbo.Courses");
            DropTable("dbo.Authors");
        }
    }
}
