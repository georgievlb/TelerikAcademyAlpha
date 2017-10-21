using System;

class PrintFloatProductSign
{
    static void Main()
    {
        float a = -78.9056f;
        float b = -28.96f;
        float c = 0.0f;
        if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine("The product is 0.");
        }
        if (a > 0 && b > 0 && c > 0)
        {
            Console.WriteLine("The product is positive");

        }
        if (a < 0 && b < 0 && c < 0)
        {
            Console.WriteLine("The product is negative");
        }
        if (a < 0 && b > 0 && c > 0)
        {
            Console.WriteLine("The product is negative");
        }
        if (a < 0 && b < 0 && c > 0)
        {
            Console.WriteLine("The product is positive");
        }
        if (a < 0 && b > 0 && c < 0)
        {
            Console.WriteLine("The product is positive");
        }
        if (a > 0 && b < 0 && c < 0)
        {
            Console.WriteLine("The product is positive");
        }
        if (a > 0 && b < 0 && c > 0)
        {
            Console.WriteLine("The product is negative");
        }
        if (a > 0 && b > 0 && c < 0)
        {
            Console.WriteLine("The product is negative");
        }
    }
}

