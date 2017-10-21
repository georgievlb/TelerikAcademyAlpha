using System;

class PrimeNumberChecker
{
    static void Main()
    {
        Console.Write("Enter a positive integer number: ");
        string consoleArgument = Console.ReadLine();
        uint number = uint.Parse(consoleArgument);
        uint divider = 2;
        uint maxDivider = (uint)Math.Sqrt(number);
        bool prime = true;
        while (prime && (divider <= maxDivider))
        {
            if (number % divider == 0)
            {
                prime = false;
            }
            else
            {
                divider++;
            }            
        }
        Console.WriteLine("Prime? {0}", prime);
        if (!prime)
        {
            Console.WriteLine("Divider: {0}", divider-1);
        }
    }
}