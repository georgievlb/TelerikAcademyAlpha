using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPartTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> list = new GenericList<int>(10);
            list.Add(10);
            list.Add(20);
            list.Add(14);
            //list.Insert(3, 1);
            //list.RemoveAt(1);
            list.Add(1);
            list.Insert(100, 0);

            Console.WriteLine("Index of 1: " + list.IndexOf(1));
            //Console.WriteLine(list.IndexOf(14));
            Console.WriteLine("List length: "+ list.Length);
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i]);
            }
            

        }

        private static void PlayWithPaths()
        {
            Point3D point = new Point3D(1, 2, 3);
            Console.WriteLine(point);
            Point3D point1 = new Point3D(1, 2, 3);
            Point3D point2 = new Point3D(1, 2, 3);
            Point3D point3 = new Point3D(1, 2, 3);
            Path path = new Path(new List<Point3D>() { point1, point2, point3 });

            Path LoadedPath = PathStorage.LoadPath(@"C:\Users\LUCHI\Documents\Mosh\part 2");
            foreach (Point3D LoadPoint in LoadedPath.Points)
            {
                Console.WriteLine();
            }
        }
    }
}
