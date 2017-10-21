using System;
using System.Numerics; // za BigInteger
class countZerosInFactorial
{
    static void Main()
    {
        BigInteger n = new BigInteger (16);
        int factorial = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }
        Console.WriteLine(factorial);
    }
}
