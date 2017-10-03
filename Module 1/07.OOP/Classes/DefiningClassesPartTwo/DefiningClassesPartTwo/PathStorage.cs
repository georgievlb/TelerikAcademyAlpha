using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPartTwo
{
    public static class PathStorage //primer za statichen klas, za nego nqma da se couple-vame
    {
        public static void SavePath(Path path, string fileName)
        {
            using (StreamWriter streamwriter = new StreamWriter(fileName))//kato go zadadem v usinga sled tova ne moje da se polzva
            {
                foreach(Point3D point in path.Points)
                {
                    streamwriter.WriteLine(point);
                }
            }
        }

        public static Path LoadPath(string filename)
        {
           
            List<Point3D> points = new List<Point3D>();
            using (StreamReader streamreader = new StreamReader(filename))
            {
                char[] splitCharacters = new char[] { 'X', 'Y', 'Z', ':', ' ', ';' };

                string line;
                while ((line = streamreader.ReadLine()) != null)
                {
                    IEnumerable<int> pointCoordinates = line.Split(splitCharacters, StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse).ToArray();
                                        
                       // Point3D point = 
                       // new Point3D(pointCoordinates[0], pointCoordinates[1], pointCoordinates[2]).points.Add(point);

                }
                
            }
            Path result = new Path(points);
            return result;
            //return new Path(points); alternative syntax for the above two lines
        }
    }
}
