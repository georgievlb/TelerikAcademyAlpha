using Academy.Models.Contracts;
using Academy.Models.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models.Academy.Course
{
    public class Lecture : ILecture
    {
        private string name;

        public Lecture(string name, string date, ITrainer trainer)
        {
            this.Name = name;
            this.Date = DateTime.Parse(date);
            this.Trainer = trainer;
            this.Resources = new List<ILectureResource>();
        }

        public DateTime Date { get; set; }
        //public DateTime Date
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

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                Validator.ValidateIfNullOrEmpty(value, "Name cannot be null!");
                Validator.ValidateMinAndMaxLength(value,
                    Constants.MinLectureLength,
                    Constants.MaxLectureLength,
                    "Lecture's name should be between 5 and 30 symbols long!");

                this.name = value;
            }
        }

        public IList<ILectureResource> Resources { get; set; }
        //public IList<ILectureResource> Resources
        //{
        //    get
        //    {
        //        throw new NotImplementedException();
        //    }
        //}

        public ITrainer Trainer { get; set; }
        //public ITrainer Trainer
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

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            foreach (var resource in Resources)
            {
                builder.Append(resource);
            }

            if (Resources.Count == 0)
            {
                return $"  * Lecture:\n   - Name: {this.Name}\n   - Date: {this.Date}\n   - Trainer username: {this.Trainer.Username}\n   - Resources:\n    * There are no resources in this lecture.\n";
            }
            else
            {
                return $"  * Lecture:\n   - Name: {this.Name}\n   - Date: {this.Date}\n   - Trainer username: {this.Trainer.Username}\n   - Resources:\n{builder.ToString()}\n";
            }
        }
    }
}
