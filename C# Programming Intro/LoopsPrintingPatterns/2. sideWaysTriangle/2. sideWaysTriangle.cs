using System;

namespace sideWaysTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <=7; i++)
            {
                for (int p = 1; p <= 4 - Math.Abs(4 - i); p++)
                {

                        Console.Write("#");             
                }
                Console.Write("\n");
            }

        }
    }
}
