using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamworkPractice
{
    public class TeamworkPracticeContext : DbContext
    {
        public TeamworkPracticeContext()
            :base("name=TeamworkPractice")
        {

        }

        public DbSet<Book> Books { get; set; }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Language> Languages { get; set; }
    }
}
