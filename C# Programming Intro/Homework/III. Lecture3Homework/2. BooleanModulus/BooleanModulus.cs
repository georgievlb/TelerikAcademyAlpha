using System;

class BooleanModulus
{
    static void Main()
    {
        int a = 22;
        bool modulus = (a % 5 == 0 && a % 7 == 0);
        Console.WriteLine(modulus);
    }
}

