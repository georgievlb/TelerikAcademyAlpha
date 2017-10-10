namespace CodeFirstExistingDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveCreateGradeColumn : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Courses", "Grade");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "Grade", c => c.String());
        }
    }
}
