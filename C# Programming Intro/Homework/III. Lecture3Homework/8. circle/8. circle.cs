using System;

class circle
{
    static void Main()
    {
        Console.WriteLine("Enter coordinates for O:");
        Console.WriteLine("x = :");
        double x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("y = :");
        double y = Convert.ToInt32(Console.ReadLine());
        double c = x * x + y * y;
        c = Math.Sqrt(c);
        Console.WriteLine((int)c <= 5 ? "leji v okrujnostta" : "ne leji v okrujnostta");
        x = (int)x;
        y = (int)y;
        Console.WriteLine((x >= -1 && x <= 5 && y >= 1 && y <= 5) ? "vutre v pravougulnika" : "izvun pravougulnika");
    }
}

