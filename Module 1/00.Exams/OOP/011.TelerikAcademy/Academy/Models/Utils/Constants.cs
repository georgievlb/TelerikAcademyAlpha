using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models.Utils
{
    public class Constants
    {
        //First and last name constraints:
        public const int MinNameLength = 3;
        public const int MaxCourseNameLength = 45;
        public const int MaxPersonNameLength = 16;

        public const int MinLecturesPerWeek = 1;
        public const int MaxLecturesPerWeek = 7;

        public const int MinUsernameLength = 3;
        public const int MaxUsernameLength = 16;

        public const int MinLectureLength = 5;
        public const int MaxLectureLength = 30;

        public const int MinExamPoints = 1;
        public const int MaxExamPoints = 1000;

        public const int MinCoursePoints = 0;
        public const int MaxCoursePoints = 125;

        public const int MinResourceNameLength = 3;
        public const int MaxResourceNameLength = 15;

        public const int MinUrlLength = 5;
        public const int MaxUrlLength = 150;

    }
}
