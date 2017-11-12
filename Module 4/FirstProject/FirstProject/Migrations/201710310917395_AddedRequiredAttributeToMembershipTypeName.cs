namespace FirstProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedRequiredAttributeToMembershipTypeName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "Name", c => c.String(nullable: false));
            DropColumn("dbo.MembershipTypes", "NameOfMembershipType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MembershipTypes", "NameOfMembershipType", c => c.String());
            DropColumn("dbo.MembershipTypes", "Name");
        }
    }
}
