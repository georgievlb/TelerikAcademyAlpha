using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstPlutoGreenField
{
    public class Author//one-to-many relationship between authors and courses. An author can have many courses but each course was created by only one author in our DB.
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Course> Courses { get; set; }
    }
}
