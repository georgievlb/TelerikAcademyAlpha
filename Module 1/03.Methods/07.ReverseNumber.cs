using System;

class Program
{
    static void Main(string[] args)
    {
        ReverseNumber();
    }

    public static int ReverseNumber()
    {
        string number = Console.ReadLine();
        int size = number.Length;
        char[] arr = new char[size];
        for (int i = 0; i < size; i++)
        {
            arr[i] = number[i];
        }
        Array.Reverse(arr);
        
        for (int i = 0; i < size; i++)
        {
            Console.Write(arr[i]);
        }
        
        return 0;
    }
}
