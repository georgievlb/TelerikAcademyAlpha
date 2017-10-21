using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Flies
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] coords = new double[3, 2];

            for (int row = 0; row < coords.GetLength(0); row++)
            {
                int i = 0;
                string[] fillMatrix = Console.ReadLine().Split(' ');
                for (int col = 0; col < coords.GetLength(1); col++)
                {
                    coords[row, col] = double.Parse(fillMatrix[i]);
                    i++;
                }
            }
            double Ax = coords[0, 0];
            double Ay = coords[0, 1];

            double Bx = coords[1, 0];
            double By = coords[1, 1];

            double Cx = coords[2, 0];
            double Cy = coords[2, 1];

            double D = 2 * (Ax * (By - Cy) + Bx * (Cy - Ay) + Cx * (Ay - By));
            double Ux = 1 / D *
                (((Math.Pow(Ax, 2) + Math.Pow(Ay, 2)) * (By - Cy) +
                     (Math.Pow(Bx, 2) + Math.Pow(By, 2)) * (Cy - Ay) +
                     (Math.Pow(Cx, 2) + Math.Pow(Cy, 2) * (Ay - By))
                ));

            double Uy = 1 / D *
                (((Math.Pow(Ax, 2) + Math.Pow(Ay, 2)) * (Cx - Bx) +
                     (Math.Pow(Bx, 2) + Math.Pow(By, 2)) * (Ax - Cx) +
                     (Math.Pow(Cx, 2) + Math.Pow(Cy, 2) * (Bx - Ax))
                ));
            //for (int row = 0; row < coords.GetLength(0); row++)
            //{
            //    for (int col = 0; col < coords.GetLength(1); col++)
            //    {
            //        if (col != col - 1)
            //            Console.Write(coords[row, col] + " ");

            //        else
            //            Console.Write(coords[row, col]);

            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine(D);
            //Console.WriteLine(Ux);
            //Console.WriteLine(Uy);
            Console.Write("{0:0.0000}", Math.Round(Ux, 4, MidpointRounding.AwayFromZero));
            Console.Write(" ");
            Console.WriteLine("{0:0.0000}", Math.Round(Uy, 4, MidpointRounding.AwayFromZero));
        }
    }
}
