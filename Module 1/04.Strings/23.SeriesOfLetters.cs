using System;

class Program
{
    static void Main(string[] args)
    {
        string inputText = Console.ReadLine();
        char[] textSeparated = new char[inputText.Length];
        for (int i = 0; i < inputText.Length; i++)
        {
            textSeparated[i] = inputText[i];
        }

        //Console.WriteLine(inputText.Length);
        Console.Write(textSeparated[0]);
        for (int i = 1; i < textSeparated.Length; i++)
        {
            if (textSeparated[i] != textSeparated[i - 1])
            {
                Console.Write(textSeparated[i]);
            }
        }


        //int length = textSeparated.Length;
        //Console.Write(textSeparated[length - 1]);
        //if (textSeparated[length - 2] == textSeparated[length - 1])
        //{
        //    Console.Write(textSeparated[length - 2]);
        //}

    }
}

