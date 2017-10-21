using System;
using System.Numerics;


class FactorialFinderMethod
{
    private static BigInteger pow(int baseofexp, int exp)
    {
        BigInteger result = baseofexp;
        for (int i = 1; i < exp; i++)
        {
            result = result * baseofexp;
        }
        return result;
    }

    private static BigInteger Factorial(BigInteger n)
    {
        if (n == 0)
            return 1;
        else
            return n * Factorial(n - 1);
    }

    static void Main(string[] args)
    {
        BigInteger n = 0;
        BigInteger result = Factorial(n);
        BigInteger power = pow(2, 4);
        Console.WriteLine(result);
        //  Console.WriteLine(pow(2, 4)); print the power without 
        //using a variable (this doesn't allocate memory!)
        BigInteger result1 = Factorial(pow(2,2));
        Console.WriteLine(result1);
    }
}

// find the power using a loop

//BigInteger result = baseofexp;
//        for (int i = 1; i<exp; i++)
//        {
//            result = result* baseofexp;
//        }
//        return result;