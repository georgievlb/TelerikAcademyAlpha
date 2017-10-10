namespace CodeFirstExistingDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateGradeColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "Grade", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Courses", "Grade");
        }
    }
}
