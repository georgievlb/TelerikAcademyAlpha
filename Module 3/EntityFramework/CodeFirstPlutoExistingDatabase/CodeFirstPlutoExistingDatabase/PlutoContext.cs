namespace CodeFirstPlutoExistingDatabase
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PlutoContext : DbContext
    {
        public PlutoContext()
            : base("name=PlutoContext")//name of connection string and DbConext is exactly the same
        {
        }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Courses> Courses { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)//this is the big difference when we get a generated model from an existing DB
        {//it is used to override the conventions IN EF
            modelBuilder.Entity<Author>()
                .HasMany(e => e.Courses)
                .WithOptional(e => e.Author)
                .HasForeignKey(e => e.Author_Id);

            modelBuilder.Entity<Courses>()
                .HasMany(e => e.Tags)
                .WithMany(e => e.Courses)
                .Map(m => m.ToTable("TagCourses").MapLeftKey("Course_Id"));
        }
    }
}
