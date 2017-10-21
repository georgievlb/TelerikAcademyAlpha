using System;

class decToBin
{
    static void Main()
    {
        Console.WriteLine("Enter a number to convert to binary: ");
        byte n = byte.Parse(Console.ReadLine());
        int bin = 0;
        int i = 1;
        while (n > 0)
        {
            bin += (n % 2) * i;
            n /= 2;
            i *= 10;
        }
        Console.WriteLine("{0:D1}", bin);
    }
}



//int number = 200;
//int bin = 0;
//int i = 1;

//        while (number > 0)
//        {
//            bin = bin + (number % 2) * i;
//number = number / 2;
//            i = i* 10;
//        }
//        Console.WriteLine(bin);