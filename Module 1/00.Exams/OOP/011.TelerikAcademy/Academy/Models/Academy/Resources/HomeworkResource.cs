using Academy.Models.Academy.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Models.Enums;

namespace Academy.Models.Academy.Resources
{
    public class HomeworkResource : LectureResource
    {
        public HomeworkResource(string name, string url, DateTime currentDate) 
            : base(name, url)
        {
            //this.ResourceType = ResourceType.Homework;
            this.DueDate = currentDate.AddDays(7);
        }

        public DateTime DueDate { get; set; }

        public override string GetResourceType()
        {
            return "Homework";
        }

        public override string GetResourceSpecificInfo()
        {
            return String.Format(@"
     - Due date: {0}", DueDate);
        }
    }
}
