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

        public DbSet<Student> Students {get; set; } //student => students by default EF pluralizes Table names (i.e. model name is pluralized)
        //in order to allow migrations, we must be at our context, in our case that is the .Data project.
        
    }
}
