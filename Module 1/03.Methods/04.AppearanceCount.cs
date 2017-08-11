using System;

class Program
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        int[] myArray = new int[size];
        string[] elementsOfArray = Console.ReadLine().Split();
        for (int i = 0; i < elementsOfArray.Length; i++)
        {
            myArray[i] = Convert.ToInt16(elementsOfArray[i]);
        }
        
        int x = int.Parse(Console.ReadLine());
        int counter = 0;
        counter = AppearanceCount(counter, x, myArray);
        Console.WriteLine(counter);
    }

    static int AppearanceCount(int counter, int x, int[] SingleArray)
    {
        for (int i = 0; i < SingleArray.Length; i++)
        {
            if (SingleArray[i] == x)
            {
                counter++;
            }
        }
        return counter;
    }
}

