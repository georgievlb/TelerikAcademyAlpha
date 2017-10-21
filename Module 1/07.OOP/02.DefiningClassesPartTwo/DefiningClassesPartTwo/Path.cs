using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPartTwo
{
    public class Path
    {
        public Path(IEnumerable<Point3D> points)
        {
            this.Points = points;
        }


        public IEnumerable<Point3D> Points
        {
            get;
            set;
        }
    }
}
