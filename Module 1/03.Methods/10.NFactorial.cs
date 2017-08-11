using System;
using System.Numerics;
class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(FactorialFinder2(number));    
    }

    //using a while loop
    public static BigInteger FactorialFinder(BigInteger number)
    {
        BigInteger factorial = new BigInteger();
        factorial = 1;
        int i = 1;
        while (i <= number)
        {
            factorial *= i;
            i++;
        }
        return factorial;
    }

    //using recursion
    public static BigInteger FactorialFinder2(BigInteger number)
    {
        if (number == 0)
            return 1;
        return (number * FactorialFinder2(number - 1));
    }
}
