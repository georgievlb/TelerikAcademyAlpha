using System;

class AllocateArray
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[] myArray = new int[N];
        for (int i = 0; i < myArray.Length; i++)
        {
            myArray[i] = i * 5;
        }

        for (int i = 0; i < myArray.Length; i++)
        {
            Console.WriteLine(myArray[i]);
        }
    }
}

