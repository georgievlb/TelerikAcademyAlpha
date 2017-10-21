using System;

class Program
{
    static void Main()
    {
        int a = 17;
        int b = 950000000;
        int counter = 0;
        for (int i = a; i <= b; i++)
        {
            
            if (i % 5 == 0)
            {
                counter++;
            }
        }
        Console.WriteLine(counter);

    }
}

