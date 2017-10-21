using System;

class BitwiseExercise3
{
    private static int userInput()
    {
        
        int a = int.Parse(Console.ReadLine());
        return a;
    }
    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        int n = userInput();
        Console.WriteLine("Enter a value 0 or 1: ");
        int v = userInput();
        Console.WriteLine("Enter position of bit: ");
        int p = userInput();
        if (v > 0)
        {
            v = v << p;
            n = n | v;
        }
        else
        {
            v = ~v;
            v = v << p;
            v = ~v;
            n = n & v;
        }
        Console.WriteLine("The new number is {0}", n);
    }
}

