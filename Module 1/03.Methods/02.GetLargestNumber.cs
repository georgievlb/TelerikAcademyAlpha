using System;

class GetMax
{
    static void Main()
    {
        //Read line, and split it by whitespace into an array of strings
        string[] numbers = Console.ReadLine().Split();

        //Parse element 0
        int a = int.Parse(numbers[0]);

        //Parse element 1
        int b = int.Parse(numbers[1]);
        int c = int.Parse(numbers[2]);
        int max = getMax(a, b);
        Console.WriteLine(getMax(max, c));
    }

    static int getMax(int x, int y)
    {
        int max = Math.Max(x, y);
        return max;
    }
}

