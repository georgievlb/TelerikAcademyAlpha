using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstLiveDemo.Models
{
    [Table("TelerikStudents")]//това ни позволява да променим името на таблицата
    public class Student
    {
        
        public Student()//student has one-to-many e.g. one student has many marks
        {
            this.Courses = new HashSet<Course>();
            this.Marks = new HashSet<Mark>();
        }

        public int Id { get; set; }

        [Required]//така се прави валидация, using Datanotations
        public string FirstName { get; set; }

        [StringLength(10,MinimumLength = 5,ErrorMessage = "LastName is not valid")]//валидация, че last name ще е м/у 5 и 10 символа
        public string LastName { get; set; }
        //нямаме minLength, minLength се поддържа директно от кода

        public int? Age { get; set; }//the ? means it's nullable

        //each property that points to another property MUST be virtual
        public virtual ICollection<Course> Courses { get; set; } //this is how you do many-to many

        public ICollection<Mark> Marks { get; set; }


    }
}
