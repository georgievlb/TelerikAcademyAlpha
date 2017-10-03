using System;
using Academy.Models.Contracts;

namespace Academy.Models
{
    public abstract class LectureResource : ILectureResource
    {
        private string name;
        private string url;

        protected LectureResource(string name, string url)
        {
            this.Name = name;
            this.Url = url;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (String.IsNullOrEmpty(value) || value.Length < 3 || value.Length > 15)
                {
                    throw new ArgumentException("Resource name should be between 3 and 15 symbols long!");
                }
                name = value;
            }
        }

        public string Url
        {
            get
            {
                return url;
            }
            set
            {
                if (String.IsNullOrEmpty(value) || value.Length < 3 || value.Length > 150)
                {
                    throw new ArgumentException("Resource url should be between 5 and 150 symbols long!");
                }
                url = value;
            }
        }

        public abstract string GetResourceType();

        public virtual string GetResourceSpecificInfo()
        {
            return "";
        }

        public override string ToString()
        {
            return string.Format(@"    * Resource:
     - Name: {0}
     - Url: {1}
     - Type: {2}{3}", Name, Url, GetResourceType(), GetResourceSpecificInfo());
        }
    }
}
