using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 5; i++)
        {
            for (int p = i; p <= 5; p++)
            {
                Console.Write("#");
            }
            Console.WriteLine();
        }
    }
}

