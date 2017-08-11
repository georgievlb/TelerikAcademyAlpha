using System;

class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int K = int.Parse(Console.ReadLine());
        int[] arr = new int[N];
        int arrLength = arr.Length;

        for (int i = 0; i < arrLength; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(arr);
        int sum = 0;
        
        for (int i = arrLength - K; i < arrLength ; i++)
        {
            sum += arr[i];
        }
        Console.WriteLine(sum);
    }
}
