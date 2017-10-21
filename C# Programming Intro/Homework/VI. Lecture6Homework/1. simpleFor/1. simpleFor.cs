using System;

class simpleFor
{
    static void Main()
    {
        Console.WriteLine("Enter a value for N: ");
        int N = int.Parse(Console.ReadLine());
        for (int i = 1; i <= N; i++)
        {
            Console.WriteLine(i);
        }
    }
}
