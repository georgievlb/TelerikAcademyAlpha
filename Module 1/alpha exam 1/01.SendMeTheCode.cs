using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        Console.SetIn(new StreamReader(Console.OpenStandardInput()));
        string text = Console.ReadLine();

        string[] convertedText = new string[text.Length];
        bool isMinus = false;           //check if the first element of the string is a minus
        for (int i = 0; i < text.Length; i++)
        {
            convertedText[i] = Convert.ToString(text[i]);
        }

        if (convertedText[0] == "-")
        {
            isMinus = true;
        }
                
        int[] parsedText = new int[convertedText.Length];
        for (int i = 1; i < convertedText.Length; i++)
        {
            parsedText[i] = int.Parse(convertedText[i]);
        }
        
        if (isMinus == false)
        {
            parsedText[0] = int.Parse(convertedText[0]);
        }

        Array.Reverse(parsedText);

        int[] indexedText = new int[parsedText.Length + 1];
        for (int i = 1; i < indexedText.Length; i++)
        {
            indexedText[i] = parsedText[i - 1];
        }
        
        int result = 0;

        for (int i = indexedText.Length - 1; i > 0; i--)
        {
            int digit = indexedText[i];
            if (i % 2 == 0)
            {
                result = ((digit * digit) * i) + result;
            }

            else if (i % 2 != 0)
            {
                result = (digit * (i * i)) + result;
            }
        }

        int lengthOfMessage = 0;

        Console.WriteLine(result);

        if (result % 10 == 0)
        {
            Console.WriteLine("Big Vik wins again!");
        }

        else
        {
            lengthOfMessage = (int)result % 10;
        }

        int remainder = result % 26;
        int startLetterOfMessage = 1 + remainder;

        string[] alphabet = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K",
            "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

        int j = startLetterOfMessage;
        for (int i = 0; i < lengthOfMessage; i++)
        {

            Console.Write(alphabet[j - 1]);
            if (j == 26)
            {
                j = 0;
            }
            j++;

        }
    }
}