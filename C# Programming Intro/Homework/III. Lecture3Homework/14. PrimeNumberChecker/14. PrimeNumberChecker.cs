using System;

class PrimeNumberChecker
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int counter = 0;
        for (int i = 1; i <= n; i++)
        {
            int remainder = n % i;
            if (remainder == 0)
            {
                counter++;
            }
        }
        if (counter == 2)
        {
            Console.WriteLine("{0} is prime", n);
        }
        else
        {
            Console.WriteLine("{0} is not prime", n);
        }

        

        
    }
}  