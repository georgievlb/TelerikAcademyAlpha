using Academy.Models.Utils.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Models.Contracts;
using Academy.Models.Enums;
using Academy.Models.Utils;

namespace Academy.Models.Academy.Course
{
    public class CourseResult : ICourseResult
    {
        //private ICourse course;
        private float coursePoints;
        private float examPoints;
        private Grade grade;

        public CourseResult(ICourse course, string examPoints, string coursePoints)
        {
            this.Course = course;            
            this.ExamPoints = float.Parse(examPoints);
            this.CoursePoints = float.Parse(coursePoints);
        }

        public ICourse Course { get; set; }
        //public ICourse Course
        //{
        //    get
        //    {
        //        return this.course;
        //    }
        //    private set
        //    {
        //        this.course = value;
        //    }
        //}

        public float CoursePoints
        {
            get
            {
                return this.coursePoints;
            }

            private set
            {
                Validator.ValidateIfNull(value, "Course points cannot be null!");
                Validator.ValidateMinAndMaxNumber(value,
                    Constants.MinCoursePoints,
                    Constants.MaxCoursePoints,
                     "Course result's course points should be between 0 and 125!");

                this.coursePoints = value;
            }
        }

        public float ExamPoints
        {
            get
            {
                return this.examPoints;
            }
            private set
            {
                Validator.ValidateIfNull(value, "Exam points cannot be null!");
                Validator.ValidateMinAndMaxNumber(value, 
                    Constants.MinExamPoints, 
                    Constants.MaxExamPoints, 
                    "Course result's exam points should be between 0 and 1000!");

                this.examPoints = value;
            }
        }

        public Grade Grade
        {
            get
            {
                return this.grade;
            }

            private set
            {
                Validator.ValidateIfNull(value, "The provided grade is not valid!"); //NOT SURE IF THIS IS THE RIGHT VALIDATION
                if ( (this.ExamPoints >= 65) || (this.CoursePoints >= 75) )
                {
                    value = Grade.Excellent;
                }
                else if ( 
                    ((this.ExamPoints < 60) && (this.examPoints>= 30)) ||
                    ((this.CoursePoints < 75) && (this.CoursePoints >= 45))
                    )
                {
                    value = Grade.Passed;
                }
                else
                {
                    value = Grade.Failed;
                }

                this.grade = value;
            }
        }

        public override string ToString()
        {
            //* <Course name>: Points - <Course points>, Grade - <Grade>
            return $" * {this.Course.Name}: Points - {this.CoursePoints}, Grade - {this.Grade}\n";
        }
    }
}
