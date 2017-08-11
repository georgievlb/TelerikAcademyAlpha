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
            myArray[i] = int.Parse(elementsOfArray[i]);
        }
        LargerThanNeighbours(size, myArray);
    }

    static void LargerThanNeighbours(int size, int[] myArray)
    {
        int counter = 0;
        for (int i = 1; i < myArray.Length - 1; i++)
        {
            if (myArray[i] > myArray[i - 1] && myArray[i] > myArray[i + 1])
            {
                counter = i;
                break;
            }

            else
            {
                counter = - 1; 
            }            
        }
        Console.WriteLine(counter);
    }
}
