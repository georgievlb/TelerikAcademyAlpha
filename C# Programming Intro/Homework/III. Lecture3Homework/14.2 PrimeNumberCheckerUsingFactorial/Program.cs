using System;

class PrimeNumberCheckerRecursionFactorial
{
    private static int factorialFinder(int x)
    {
        if (x == 1)
        return 1;
        else
        return x * factorialFinder(x - 1);
    }
    static void Main()
    {
        ////tuk e s cikul for
        //int a = 5;
        //int factorial = 1;
        //for (int i = 1; i <=5; i++)
        //{
        //    factorial = factorial * i;
        //}
        //Console.WriteLine(factorial);

        // tuk e s rekursiq
        int n = int.Parse(Console.ReadLine());
        int result = (factorialFinder(n - 1) + 1) % n;
        if (result == 0)
            Console.WriteLine("{0} is prime", n);
        else
            Console.WriteLine("{0} is not prime", n);
    }
}

