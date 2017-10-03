using Academy.Models.Contracts;
using Academy.Models.Utils;
using Academy.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Models.Academy.Abstractions;

namespace Academy.Models.Academy.Resources
{
    public class DemoResource : LectureResource
    {
        public DemoResource(string name, string url) 
            : base(name, url)
        {
           // this.ResourceType = ResourceType.Demo;
        }

        public override string GetResourceType()
        {
            return "Demo";
        }
    }
}
