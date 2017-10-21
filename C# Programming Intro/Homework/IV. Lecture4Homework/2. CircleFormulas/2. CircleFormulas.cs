using System;

class Program
{
    static void Main()
    {
        float radius = 0;

        while (true)
        {
            Console.WriteLine("Enter a value for r: ");
            string r = Console.ReadLine();
            if (float.TryParse(r, out radius))
            {
                break;
            }
            else
            {
                Console.WriteLine("Bad input");
            }
        }
        string area = "S = ";
        string perimeter = "P = ";
        Console.WriteLine("{0} | {1, 25}", area, Math.PI*radius*radius);
        Console.WriteLine("{0} | {1, 25}", perimeter, 2* Math.PI * radius);
    }
}

