using System;

class factorialCalculator
{
    static void Main()
    {
        Console.WriteLine("Enter a value for N that is > 1");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a value for K that is > 1 and < N");
        int k = int.Parse(Console.ReadLine());

        int factorial1 = 1;
        for (int i = 1; i <= n; ++i)
        {
            factorial1 *= i;
        }
        Console.WriteLine(factorial1);

        int factorial2 = 1;
        for (int i = 1; i <= k; ++i)
        {
            factorial2 *= i;
        }
        Console.WriteLine(factorial2);
        Console.WriteLine("N!/K! = {0}", factorial1/factorial2);
    }
}

