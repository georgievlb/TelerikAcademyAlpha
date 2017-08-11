using Academy.Models.Academy.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Models.Enums;
using Academy.Core.Providers;

namespace Academy.Models.Academy.Resources
{
    public class VideoResource : LectureResource
    {
        public VideoResource(string name, string url, DateTime uploadDate) 
            : base(name, url)
        {
            //this.ResourceType = ResourceType.Video;
            this.UploadDate = DateTimeProvider.Now;

        }

        public DateTime UploadDate { get; set; }

        public override string GetResourceType()
        {
            return "Video";
        }

        public override string GetResourceSpecificInfo()
        {
            return String.Format(@"
     - Uploaded on: {0}", UploadDate);
        }
    }
}
