using System;

namespace QuadraticEquation
{
    class Program
    {
        static void Main()
        {
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());
            float d = (b * b) - (4 * a * c);
            if (d < 0)
            {
                Console.WriteLine("No solution.");
            }
            
            else if (d == 0)
            {
                float x = (-b) / (2 * a);
                Console.WriteLine("x = {0}", x);
            }

            else if (d > 0)
            {
                float x1 = (float) (-b + Math.Sqrt(d)/ 2 * a);
                Console.WriteLine("x1 = {0}", x1);
                float x2 = (float) (-b - Math.Sqrt(d) / 2 * a);
                Console.WriteLine("x2 - {0}", x2);
            }
        }
    }
}
