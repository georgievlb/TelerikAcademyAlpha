using Academy.Core.Contracts;
using Academy.Core.Providers;
using Academy.Models;
using Academy.Models.Academy.Abstractions;
using Academy.Models.Academy.Course;
using Academy.Models.Academy.Participants;
using Academy.Models.Academy.Resources;
using Academy.Models.Contracts;
using Academy.Models.Enums;
using Academy.Models.Utils.Contracts;
using System;

namespace Academy.Core.Factories
{
    public class AcademyFactory : IAcademyFactory
    {
        private static IAcademyFactory instanceHolder = new AcademyFactory();

        // private because of Singleton design pattern
        private AcademyFactory()
        {
        }

        public static IAcademyFactory Instance
        {
            get
            {
                return instanceHolder;
            }
        }

        public ISeason CreateSeason(string startingYear, string endingYear, string initiative)
        {
            var parsedStartingYear = int.Parse(startingYear);
            var parsedEngingYear = int.Parse(endingYear);

            Initiative parsedInitiativeAsEnum;
            Enum.TryParse<Initiative>(initiative, out parsedInitiativeAsEnum);

            return new Season(parsedStartingYear, parsedEngingYear, parsedInitiativeAsEnum);
        }

        public IStudent CreateStudent(string username, string track)
        {

            //Track finalTrack = new Track();
            //Enum.TryParse(track, true, out finalTrack);

            Track trackEnum;
            if (!Enum.TryParse(track, out trackEnum))
            {
                throw new ArgumentException("The provided track is not valid!");
            }
            else
            {
                return new Student(username, trackEnum, null);
            }

            //return new Student(username, finalTrack);
           
        }

        public ITrainer CreateTrainer(string username, string technologies)
        {
            return new Trainer(username, technologies);
        }

        public ICourse CreateCourse(string name, string lecturesPerWeek, string startingDate)
        {
            
                int tempVariable = 0;
            int.TryParse(lecturesPerWeek, out tempVariable);

            DateTime tempVariable2 = DateTime.Now;
            DateTime.TryParse(startingDate, out tempVariable2);

                return new Course(name, tempVariable, tempVariable2);
            //throw new NotImplementedException("Course class not attached to factory.");
        }

        public ILecture CreateLecture(string name, string date, ITrainer trainer)
        {
            // TODO: Implement this
            //throw new NotImplementedException("Lecture class not attached to factory.");
            return new Lecture(name, date, trainer);
        }

        public ILectureResource CreateLectureResource(string type, string name, string url)
        {
            //ResourceType finalResource = new ResourceType();
            //Enum.TryParse(type, true, out finalResource);
            //// Use this instead of DateTime.Now if you want any points in BGCoder!!
            var currentDate = DateTimeProvider.Now;
            //ILectureResource Resource;
            //TODO
            //switch (type)
            //{
            //    case "video":
            //        Resource = new VideoResource(name, url, currentDate);
            //        break;
            //    case "presentation":
            //        Resource = new PresentationResource(name, url);
            //        break;
            //    case "demo":
            //        Resource = new DemoResource(name, url);
            //        break;
            //    case "homework":
            //        Resource = new HomeworkResource(name, url, currentDate);
            //        break;
            //    default: throw new ArgumentException("Invalid lecture resource type");
            //}

            switch (type)
            {
                case "video":
                    return new VideoResource(name, url, currentDate);
                case "presentation":
                    return new PresentationResource(name, url);
                case "demo":
                    return new DemoResource(name, url);
                case "homework":
                    return new HomeworkResource(name, url, currentDate);
                default: throw new ArgumentException("Invalid lecture resource type");
            }
                        
            //return Resource;
        }

        public ICourseResult CreateCourseResult(ICourse course, string examPoints, string coursePoints)
        {
            // TODO: Implement this
            //throw new NotImplementedException("CourseResult class not attached to factory.");
            return new CourseResult(course, examPoints, coursePoints);
        }
    }
}
