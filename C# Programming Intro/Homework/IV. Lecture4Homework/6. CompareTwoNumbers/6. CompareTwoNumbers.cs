using System;

class CompareTwoNumbers
{
    static void Main()
    {
        int a = 10;
        int b = 20;
        //lesser number -use Math.min
        Console.WriteLine(Math.Min(a, b));

        // or use Math.Abs
        Console.WriteLine((a + b - Math.Abs(a - b)) / 2);

        //greater number - use Math.Max
        Console.WriteLine(Math.Max(a, b));

        //or use Math.Abs
        Console.WriteLine((a + b + Math.Abs(a - b)) / 2);


    }
}

