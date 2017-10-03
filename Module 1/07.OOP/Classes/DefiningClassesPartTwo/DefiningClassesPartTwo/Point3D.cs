using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPartTwo
{
   

    public struct Point3D//konstruktor bez parametri zadyuljitelno za strukturite
    {
        private static readonly Point3D startPoint = new Point3D(0, 0, 0); //private static readonly field , in camelCase constant fields are PascalCase
        public Point3D(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static Point3D StartPoint
        {
            get
            {

                return startPoint;
            }

        }//shte ima samo getter


        //static constructor se izvikva pri purvata nujda ot upotreba na tozi tip
        // a inache se pishe static Point3D() {}
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }

        public override string ToString()
        {
            return $"x: {this.x}, y:{this.y}, z:{this.z}";
       
        }

    }
}
