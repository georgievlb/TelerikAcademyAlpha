using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 4; i++)
        {
            for (int p = 1; p <= 8; p++)
            {
                if (p > Math.Abs(i - 9) || (p < i))
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write("#");
                }
            }
            Console.WriteLine("");
        }
    }
}

