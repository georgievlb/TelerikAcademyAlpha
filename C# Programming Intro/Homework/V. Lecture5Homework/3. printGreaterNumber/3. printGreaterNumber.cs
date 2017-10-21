using System;

class printGreaterNumber
{
    static void Main()
    {
        Console.WriteLine("Enter 3 integers to compare: ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());

        if (a > b && a > c)
        {
            Console.WriteLine("{0} is the largest number", a);
        }
        else
        {
            if (b > a && b > c)
            {
                Console.WriteLine("{0} is the largest number", b);
            }
            else 
            {
                Console.WriteLine("{0} is the largest number", c);
            }

        
        }
    }
}

