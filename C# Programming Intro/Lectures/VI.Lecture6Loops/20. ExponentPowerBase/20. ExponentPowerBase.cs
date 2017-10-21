using System;

class ExponentPowerBaseram
{
    static void Main()
    {
        int baseOfPow = int.Parse(Console.ReadLine());
        int exponent = int.Parse(Console.ReadLine());
        int total = 1;

        for (int counter = 0; counter < exponent; counter++)
        {
            total *= baseOfPow;
        }
        Console.WriteLine("{0}^{1} = {2}", baseOfPow, exponent, total);
    }
}


