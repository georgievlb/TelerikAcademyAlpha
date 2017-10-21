using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int number = n;
        decimal product = 1;
        do
        {
            product = product * number;
            number++;
        }
        while (number <= m);
        Console.WriteLine("product[n..m] = " + product);
        
    }
}

