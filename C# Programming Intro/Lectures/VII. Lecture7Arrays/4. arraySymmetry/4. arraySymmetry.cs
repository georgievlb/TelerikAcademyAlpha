using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the size of the array: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        Console.WriteLine("Enter the elements of the array: ");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        
        bool symmetry = true;
        for (int i = 0; i < array.Length/2; i++)
        {
            if (array[i] != array[n - i - 1])
                symmetry = false;
        }
        Console.WriteLine("Is symmetric: " + symmetry);
    }
}

