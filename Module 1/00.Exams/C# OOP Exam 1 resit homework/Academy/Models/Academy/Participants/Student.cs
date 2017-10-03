using Academy.Models.Academy.Abstractions;
using Academy.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Models.Enums;
using Academy.Models.Utils.Contracts;
using Academy.Models.Utils;

namespace Academy.Models.Academy.Participants
{
    public class Student : AcademyPerson, IStudent
    {
        private Track track;
        //private List<ICourseResult> courseResults;

       // public Student(string username, Track track)
       //     : base(username)
       // {
       //     this.Track = track;
       // }

        public Student(string username, Track track, IList<ICourseResult> courseResults) 
            : base(username)
        {
            this.Track = track;
            this.CourseResults = new List<ICourseResult>();
        }
        public IList<ICourseResult> CourseResults { get; set; }
        //public IList<ICourseResult> CourseResults                 //FROM INTERFACE
        //{
        //    get
        //    {
        //        throw new NotImplementedException();
        //    }

        //    set
        //    {
        //        throw new NotImplementedException();
        //    }
        //}

        public Track Track
        {
            get
            {
                return this.track;
            }

            set
            {
                //Validator.ValidateIfNullOrEmpty(value, "The provided track is not valid!"); //NOT SURE IF THIS IS THE RIGHT VALIDATION
                
                this.track = value;
               
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            foreach (var result in CourseResults)
            {
                builder.Append(result);
            }
            if (CourseResults.Count == 0)
            return $"* Student:\n - Username: {this.Username}\n - Track: {this.Track}\n - Course results:\n  * User has no course results!";

            else
                return $"* Student:\n - Username: {this.Username}\n - Track: {this.Track}\n - Course results:\n " + builder.ToString();

        }
    }
}
