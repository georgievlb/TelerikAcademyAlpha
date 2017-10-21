using System;

class shape2
{
    static void Main()
    {
        for (int i = 4; i >= 1; i--)
        {
            for (int p = 8; p >= i; p--)
            {
                if (p >= Math.Abs(i - 10))
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

