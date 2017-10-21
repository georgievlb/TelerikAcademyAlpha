using System;

class Program
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        // Calculate n! = 1 * 2  * ... *n
        int result = 1;
        while (true)
        {
            if (n == 1)
                break;
            result *= n;
            n--;
        }
        Console.WriteLine("n! = " + result);
    }
}
    



