using Academy.Models.Academy.Abstractions;
using Academy.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models.Academy.Resources
{
    public class PresentationResource : LectureResource
    {
        public PresentationResource(string name, string url) 
            : base(name, url)
        {
            //this.ResourceType = ResourceType.Presentation;
        }

        public override string GetResourceType()
        {
            return "Presentation";
        }
    }
}
