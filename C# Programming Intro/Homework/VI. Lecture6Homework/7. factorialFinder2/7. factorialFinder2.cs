using System;

class factorialFinder2
{
    static void Main()
    {
        int n = 15;
        int k = 10;
        int factorial1 = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial1 *= i;
            
        }
        Console.WriteLine(factorial1);
        int factorial2 = 1;
        for (int i = 1; i <= k; i++)
        {
            factorial2 *= i;
        }
        Console.WriteLine(factorial2);

        int factorial3 = 1;
        for (int i = 1; i <= n-k; i++)
        {
            factorial3 *= i;
        }
        Console.WriteLine(factorial3);
        Console.WriteLine("N!*K!/(N-K)! = {0}", (factorial1*factorial2)/factorial3);
    }
}

