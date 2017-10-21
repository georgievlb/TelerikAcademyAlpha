using System;

class StringExercise2
{
    static void Main()
    {
        string hi = "Hello ";
        string wo = "World";
        object sum = hi + wo;
        string full = (string) sum;
        Console.WriteLine(full);
    }
}
