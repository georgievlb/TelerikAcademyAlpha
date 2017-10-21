using System;

class ReadAndPrintSum
{
    static void Main()
    {
        int a;
        a = int.Parse(Console.ReadLine());
        int b;
        b = int.Parse(Console.ReadLine());
        int c;
        c = Convert.ToInt32(Console.ReadLine());
        //втори вариант
        //int d = a + b + c;

        Console.WriteLine("The sum of {0} + {1} + {2} = {3} ", a , b, c, a + b + c);
        //Console.WriteLine(d);
    }
}

