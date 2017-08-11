using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string inputText = "Hi exam";
        string[] words = inputText.Split(' ');
        Console.WriteLine(inputText);
        int longestWord =
            //Math.Max(
            Math.Max(words[0].Length, words[1].Length);
        //Math.Max(words[1].Length, words[2].Length) );
        Console.WriteLine(longestWord);
        for (int i = 1; i <= longestWord; i++) //върти до дължината на най-дългата дума за да изпечата всички букви
                                               //дори когато думите в масива words са с различна дължина
        {
            for (int j = 0; j < words.Length; j++) //върти думите
            {
                if (words[j].Length >= i)    //
                {
                    string newWords = words[j];
                    Console.Write(newWords[newWords.Length - i]);
                }
            }
            //Console.Write(" ");

        }


        //StringBuilder builder = new StringBuilder();
        //StringBuilder deleteLetters = new StringBuilder();  //unused
        //string letters;
        //int j = 1;
        //Console.WriteLine(inputText);
        //for (int i = 0; i < words.Length; i++)
        //{
        //    letters = words[i];
        //    letters = words[i].Substring(0, letters.Length);
        //    builder.Append(letters[letters.Length - j]);

        //    //Console.WriteLine(letters[letters.Length - 1]);
        //    //for (int j = 1; j < letters.Length; j++)
        //    //{
        //    //    builder.Append(letters[letters.Length - j]);
        //    //}


        //}
        //Console.WriteLine(builder.ToString());
    }
}
