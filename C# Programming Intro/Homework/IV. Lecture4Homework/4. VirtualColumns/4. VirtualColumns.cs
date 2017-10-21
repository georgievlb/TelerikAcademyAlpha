using System;

class Program
{
    static void Main()
    {
        int hex = 0xA03;
        Console.Write("|{0, -10:F2}|", hex);
        float second = 90.2312f;
        Console.Write("|{0, -10:F2}|", second);
        float third = -921.1233f;
        Console.WriteLine("|{0,-10:F2}|", third);
    }
}

