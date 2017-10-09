using System.Collections.Generic;
using System.Data.Entity;

namespace CodeFirstPluto
{
    public class Course //each course is created by only one author
    {//a course can have multiple tags
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public CourseLevel Level { get; set; }
        public float FullPrice { get; set; }
        public Author author { get; set; }
        public IList<Tag> Tags { get; set; }
    }

    public class Author //navigation property to author tag. Also we have a one-to-many relationship between authors and courses
    {//an author can have many courses
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Course> Courses { get; set; }
    }

    public class Tag // a tag can be applied to multiple courses
    {//many-to-many
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Course> Courses { get; set; }
    }

    public enum CourseLevel
    {
        Beginner = 1,
        Intermediate = 2,
        Advanced = 3
    }

    public class PlutoContext: DbContext
    {
        //a collectio of objects that represent a table in the databse
        public DbSet<Course> Courses { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Tag> Tags { get; set; }

        public PlutoContext()
            :base("name=DefaultConnection")// we can specify fyll connection string but its not recommended - store it in configuration file
        {

        }
    }

   

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
