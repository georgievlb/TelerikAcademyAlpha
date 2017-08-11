using System;

class Program
{
    static void Main(string[] args)
    {
        string text = Console.ReadLine();
        if (text.Length > 20)
        {
            Console.WriteLine(MaxLengthOfString(text, 20));
        }

        else
        {
            Console.WriteLine(text.PadRight(20, '*'));            
        }
        
        
    }

    public static string MaxLengthOfString(string userInput, int length)
    {
        if (string.IsNullOrWhiteSpace(userInput) == false && userInput.Length > length)
        {
            return userInput.Substring(0, 20);            
        }
        return userInput;
    }
        
}
