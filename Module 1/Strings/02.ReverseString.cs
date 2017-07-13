using System;

class Program
{
    static void Main(string[] args)
    {
        string firstString = Console.ReadLine();
        reverseString(firstString);
    }

    static void reverseString(string firstString)
    {
        char[] myArray = new char[firstString.Length];

        for (int i = 0; i < firstString.Length; i++)
        {
            myArray[i] = firstString[i];
        }

        string reverseString = Convert.ToString(firstString[firstString.Length - 1]);

        for (int i = firstString.Length - 2; i >= 0; i--)
        {
            reverseString += firstString[i];
        }
        Console.WriteLine(reverseString);
    }
}

