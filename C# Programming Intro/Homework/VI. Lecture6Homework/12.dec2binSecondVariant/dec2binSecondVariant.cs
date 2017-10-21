using System;

class dec2binSecondVariant

{
    private static int compareToPow(int x, int pow)
    {
        if (x >= pow)
        {
            Console.Write("1");
        }
        else
        {
            Console.Write("0");
        }

        if (x >= pow)
        {
            return x - pow;
        }
        else
        {
            return x;
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number to convert: ");
        int a =int.Parse(Console.ReadLine());
        a = (compareToPow(a, 128));
        a = (compareToPow(a, 64));
        a = (compareToPow(a, 32));
        a = (compareToPow(a, 16));
        Console.Write(" ");

        a = (compareToPow(a, 8));
        a = (compareToPow(a, 4));
        a = (compareToPow(a, 2));
        a = (compareToPow(a, 1));
        Console.WriteLine();
        int hex = 0x123;
        Console.WriteLine(hex);
    }
}


