using System.Collections.Generic;
using System.Data.Entity;

namespace CodeFirstPlutoGreenField //MODEL
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public CourseLevel Level { get; set; }
        public float FullPrice { get; set; }
        public Author Author { get; set; }  //navigation property to the author type
        public IList<Tag> Tags { get; set; }
    }

    public class Author//one-to-many relationship between authors and courses. An author can have many courses but each course was created by only one author in our DB.
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Course> Courses { get; set; }
    }

    public class Tag//many-to-many relationship between courses and tags - a tag can have many courses
    {//and courses can have multiple tags
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

    public class PlutoContext : DbContext//CONTEXT
    {
        //we are going to have a bunch of DbSets - this is a collection of objects that represent data in the database
        public DbSet<Course> Courses { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Tag> Tags { get; set; }

        //because we have broken the naming convention for our connection string, we need
        //to specifically tell EF what it is
        public PlutoContext()
            :base("name=DefaultConnection")//we can specify the full connectionString (not recommended by Mosh)but it's better to store in configuration file
            //or specify the name of this connection string in the configuration file
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
