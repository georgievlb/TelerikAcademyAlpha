using System;
using System.Numerics;

class CatalansNumbers
{
    private static BigInteger factorial(int n)
    {

        int factorialN = 1;
        for (int i = 1; i <= n; i++)
        {
            factorialN *= i;
        }
        return factorialN;
    }
    static void Main()
    {
        
        Console.WriteLine("Enter a value for n > 0: ");
        int n = int.Parse(Console.ReadLine());
        BigInteger result = (factorial(2 * n)) / factorial(n + 1) * factorial(n);
        Console.WriteLine("Catalan's number = {0}", result);
      
    }
   
}

