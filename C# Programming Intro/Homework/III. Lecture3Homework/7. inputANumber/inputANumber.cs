using System;

class inputANumber
{
    static void Main()
    {
        Console.WriteLine("Enter your weight: ");
        int weight;
        weight = Convert.ToInt32(Console.ReadLine());
        Console.Write("Your weight on the moon will be: ");
        Console.WriteLine((double)weight * 0.17);
    }
}

