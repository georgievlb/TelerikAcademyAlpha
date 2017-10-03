using Academy.Models.Contracts;
using Academy.Models.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models.Academy.Course
{
    public class Course : ICourse
    {
        private string name;
        private int lecturesPerWeek;
        private DateTime startingDate;
        private DateTime endingDate;
        private  readonly IList<ILecture> lectures = new List<ILecture>();
        //private int onSiteStudents;
        //private int onlineStudents;

        public DateTime EndingDate
        {
            get
            {
                return this.startingDate.AddDays(30);
            }

            set
            {
                this.endingDate = value;
            }
        }

        public IList<ILecture> Lectures { get; set; }

        public int LecturesPerWeek
        {
            get
            {
                return this.lecturesPerWeek;
            }

            set
            {
                Validator.ValidateIfNull(value);
                Validator.ValidateMinAndMaxNumber(value, 
                    Constants.MinLecturesPerWeek, 
                    Constants.MaxLecturesPerWeek, 
                    "The number of lectures per week must be between 1 and 7!");

                this.lecturesPerWeek = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                Validator.ValidateIfNullOrEmpty(value, "The name of the course must be between 3 and 45 symbols!");
                Validator.ValidateMinAndMaxLength(value, 
                    Constants.MinNameLength,
                    Constants.MaxCourseNameLength,
                    "The name of the course must be between 3 and 45 symbols!");

                this.name = value;
            }
        }

        //public IList<IStudent> OnlineStudents
        //{
        //    get
        //    {
        //        throw new NotImplementedException();
        //    }
        //}

        public IList<IStudent> OnlineStudents { get; set; }

        //public IList<IStudent> OnsiteStudents
        //{
        //    get
        //    {
        //        throw new NotImplementedException();
        //    }
        //}

        public IList<IStudent> OnsiteStudents { get; set; }

        public DateTime StartingDate
        {
            get
            {
                return this.startingDate;
            }

            set
            {
                
                this.startingDate = value;
            }
        }

        public Course(string name, int lecturesPerWeek, DateTime startingDate)
        {
            this.Name = name;
            this.LecturesPerWeek = lecturesPerWeek;
            this.StartingDate = startingDate;
            this.Lectures = new List<ILecture>();
            this.OnsiteStudents = new List<IStudent>();
            this.OnlineStudents = new List<IStudent>();
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            foreach (var lecture in Lectures)
            {
                builder.Append(lecture);
            }

            if (Lectures.Count > 0)
            return $"* Course:\n - Name: {this.Name}\n - Lectures per week: {this.LecturesPerWeek}\n - Starting date: {this.StartingDate}\n - Ending date: {this.EndingDate}\n - Onsite students: {this.OnsiteStudents.Count}\n - Online students: {this.OnlineStudents.Count}\n - Lectures:\n{builder.ToString()}";

            else
                return $"* Course:\n - Name: {this.Name}\n - Lectures per week: {this.LecturesPerWeek}\n - Starting date: {this.StartingDate}\n - Ending date: {this.EndingDate}\n - Onsite students: {this.OnsiteStudents.Count}\n - Online students: {this.OnlineStudents.Count}\n - Lectures:\n  * There are no lectures in this course!\n";
            

        }
    }

}
