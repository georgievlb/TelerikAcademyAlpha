using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstPlutoGreenField
{
    public class PlutoContext : DbContext
    {
        //we are going to have a bunch of DbSets - this is a collection of objects that represent data in the database
        public DbSet<Course> Courses { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Tag> Tags { get; set; }

        //because we have broken the naming convention for our connection string, we need
        //to specifically tell EF what it is
        public PlutoContext()
            : base("name=DefaultConnection")//we can specify the full connectionString (not recommended by Mosh)but it's better to store in configuration file
                                            //or specify the name of this connection string in the configuration file
        {

        }
    }
}
