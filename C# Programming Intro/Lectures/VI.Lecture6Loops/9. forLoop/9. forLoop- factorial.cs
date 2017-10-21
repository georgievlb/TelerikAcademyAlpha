using System;

class Factorial
{
    static void Main()
    {
        int n = 5;
        int factorial = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }
        Console.WriteLine(factorial);
    }
}

