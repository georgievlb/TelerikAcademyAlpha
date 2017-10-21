using System;

namespace CompareNumbers
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter five numbers: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            if (a > b && a > c && a > d && a > e)
                Console.WriteLine("{0} is the largest number.", a);
            if (b > a && b > c && b > d && b > e)
                Console.WriteLine("{0} is the largest number.", b);
            if (c > a && c > b && c > d && c > e)
                Console.WriteLine("{0} is the largest number.", c);
            if (d > a && d > b && d > c && d > e)
                Console.WriteLine("{0} is the largest number.", d);
            if (e > a && e > b && e > c && e > d)
                Console.WriteLine("{0} is the largest number.", e);

        }
    }
}
