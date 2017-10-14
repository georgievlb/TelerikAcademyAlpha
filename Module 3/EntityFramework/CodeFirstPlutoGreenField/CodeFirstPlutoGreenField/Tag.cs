using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstPlutoGreenField
{
    public class Tag//many-to-many relationship between courses and tags - a tag can have many courses
    {//and courses can have multiple tags
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Course> Courses { get; set; }
    }
}
