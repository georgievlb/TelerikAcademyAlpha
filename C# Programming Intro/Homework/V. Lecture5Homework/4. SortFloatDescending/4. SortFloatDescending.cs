using System;


class SortFloatDescending
{
    static void Main()
    {
        int a = 100;
        int b = 200;
        int c = 300;
        int d = 400;
        int e = 500;
        bool bigA = (a > b && a > c && a > d && a > e);
        bool bigB = (b > a && b > c && b > d && b > e);
        bool bigC = (c > a && c > b && c > d && c > e);
        bool bigD = (d > a && d > b && d > c && d > e);
        bool bigE = (e > a && e > b && e > c && e > d);
        if (bigA)
        {
            Console.WriteLine("A IS BIG");
        }
        else if (bigB)
        {
            Console.WriteLine("B IS BIG");
        }
        else if (bigC)
        {
            Console.WriteLine("C IS BIG");
        }
        else if (bigD)
        {
            Console.WriteLine("D IS BIG");

        }
        else if (bigE)
                {
            Console.WriteLine("E IS BIG");
                }
        
    }   
}

