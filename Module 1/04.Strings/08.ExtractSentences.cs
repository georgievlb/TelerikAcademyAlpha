using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string findWord = Console.ReadLine();
        string userInput = Console.ReadLine();
        string[] sentences = userInput.Split('.');
        for (int i = 0; i < sentences.Length; i++)
        {
            sentences[i] = sentences[i].Trim(' ');
        }

        StringBuilder builder = new StringBuilder();
        //Console.WriteLine($"sentences: ");

        //for (int i = 0; i < sentences.Length; i++)
        //{
        //    Console.WriteLine(sentences[i]);
        //}

        //Console.WriteLine($"words: ");
        for (int i = 0; i < sentences.Length; i++)
        {
            string[] words = sentences[i].Split(' ');

            for (int j = 0; j < words.Length; j++)
            {
                //Console.WriteLine(words[j] + "what?");
                bool equalsIgnoreCase = (words[j].Equals(findWord, StringComparison.CurrentCultureIgnoreCase));
                if (equalsIgnoreCase)
                    builder.Append(sentences[i] + '.' + ' ');

            }
        }

        Console.WriteLine(builder.ToString().TrimEnd());
    }
}