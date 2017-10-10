using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstLiveDemo.Models
{
    public class Course
    {
        public Course()//you have to initialize the collection so it's not null
        {
            this.Students = new HashSet<Student>();//call virtual method in a CTOR - this is a known issue but EF fixes it.
        }

        public int Id { get; set; }

        //if you follow convention i.e. name it Id, EF recognizes it

        public string Name { get; set; }

        public virtual ICollection<Student> Students { get; set; } //EF rewrites it and places the collection that is placed in the students table
        //virtual methods can be overriden runtime
    }
}
