using CodeFirstLiveDemo.Models;
using System.Data.Entity;

namespace CodeFirstLiveDemo.Data
{
    public class StudentSystemContext : DbContext
    {
        public StudentSystemContext()
            : base("name=StudentSystem")
        {

        }
        //below is FluentAPI
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //задължително му се вика base иначе
        //}

        public DbSet<Student> Students {get; set; } //student => students by default EF pluralizes Table names (i.e. model name is pluralized)
                                                    //in order to allow migrations, we must be at our context, in our case that is the .Data project.

        //таблиците се създават защото и трите имат връзка помежду си. Когато вдигаме students.
        public DbSet<Course> Courses { get; set; }

        public DbSet<Mark> Marks { get; set; }

        public DbSet<Log> Logs { get; set; }
    }
}
