namespace CodeFirstLiveDemo.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<CodeFirstLiveDemo.Data.StudentSystemContext> //changed internal to public
    {
        public Configuration()
        {
            //this.AutomaticMigrationsEnabled = true;//this is set to true ONLY during development. In production it's set to false; Also, the "this" keyword should always be applied.
            //AutomaticMigrationDataLossAllowed = true; //added this just for the sake of remembering what it does. THIS SHOULD NEVER BE TRUE IN PRODUCTION!
            ContextKey = "CodeFirstLiveDemo.Data.StudentSystemContext";
        }

        protected override void Seed(CodeFirstLiveDemo.Data.StudentSystemContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
