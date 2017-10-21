using System;

class BitwiseExercise2
{
    private static bool bitOneOrZero(int number, int position)
    {
        // tova neshto vsusthnost pravi
        //int mask = 1;
        //mask = mask << pos;
        //mask = num & mask;
        //mask = mask >> pos;
        //
        if ((number & (1 << position)) == 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    static void Main()
    {
        Console.WriteLine("Enter an integer: ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter bit position to check");
        int pos = int.Parse(Console.ReadLine());
        Console.WriteLine("Bit is one: " + bitOneOrZero(num, pos));


    }
}

