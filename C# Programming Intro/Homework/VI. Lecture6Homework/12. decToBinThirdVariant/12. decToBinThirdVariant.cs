using System;

class decToBinThirdVariant
{
    private static int decToBinDigits(int n)
    {
        int bin = 0;
        int i = 1;

        while (n > 0)
        {
            bin = bin + (n % 2)  * i;
            n = n / 2;
            i = i * 10;
            
        }
        Console.WriteLine(bin);
        return bin;
    }
        static void Main()
    {
       decToBinDigits(12);
        //int number = 19;
        //int bin = 0;
        //int i = 1;

        //while (number > 0)
        //{
        //    bin = bin + (number % 2) * i;
        //    number = number / 2;
        //    i = i * 10;
        //}
        //Console.WriteLine(bin);
    }
}

