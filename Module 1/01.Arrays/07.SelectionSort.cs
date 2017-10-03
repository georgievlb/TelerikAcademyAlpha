using System;

namespace SelectionSort
{
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

            int min = int.MaxValue;

            for (int i = 0; i < arr.Length; i++)
            {
                min = arr[i];
                for (int j = i; j < arr.Length; j++)
                {
                    if (min > arr[j])
                    {
                        min = arr[j];
                        arr[j] = arr[i];
                        arr[i] = min;
                    }
                    
                }
            }
            
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}



class didi
{
    void sort(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            int min = arr[i];
            for (int j = i; j < arr.Length; j++)
            {
                if (min > arr[j])
                {
                    min = arr[j];
                }

                int swap = arr[i];
                arr[i] = arr[j];
                arr[j] = swap;
            }
        }
    }
}