using System.Collections.Generic;

namespace CodeFirstLiveDemo.Models
{
    public class Student
    {
        public Student()//student has one-to-many e.g. one student has many marks
        {
            this.Courses = new HashSet<Course>();
            this.Marks = new HashSet<Mark>();
        }

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int? Age { get; set; }//the ? means it's nullable

        //each property that points to another property MUST be virtual
        public virtual ICollection<Course> Courses { get; set; } //this is how you do many-to many

        public ICollection<Mark> Marks { get; set; }


    }
}
