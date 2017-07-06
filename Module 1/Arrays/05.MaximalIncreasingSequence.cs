using System;

class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int[] arr = new int[N];

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        int lengthOfSequence = 0;
        int currentCounter = 1;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] < arr[i + 1])
            {
                currentCounter++;
            }

            else
            {
                currentCounter = 1;
            }


            if (currentCounter != 0 && lengthOfSequence < currentCounter)
            {
                lengthOfSequence = currentCounter;  //add 1 to include the first equal sequence element
            }
        }
        Console.WriteLine(lengthOfSequence);
    }
}
