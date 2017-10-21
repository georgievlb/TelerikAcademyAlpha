using System;

class BitwiseExercise
{
    static void Main()
    {
        int n = 84;
        int mask = 1;
        mask = mask << 2;
        int result = n & mask;
        result = result >> 2;
        Console.WriteLine(result);
        if (result == 1)
        {
            Console.WriteLine("The third bit is {0}", 1);
        }
        else
        {
            Console.WriteLine("The third bit is {0}", 0);
        }
        
    }
}

