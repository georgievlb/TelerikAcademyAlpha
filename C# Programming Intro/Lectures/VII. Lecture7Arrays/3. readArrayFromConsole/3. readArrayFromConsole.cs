using System;

class readArrayFromConsole
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        } 

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + ",");
        }
    }
}

