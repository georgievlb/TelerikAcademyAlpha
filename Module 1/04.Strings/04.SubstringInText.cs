using System;

class Program
{
    static void Main(string[] args)
    {
        string subString = Console.ReadLine();
        string mainString = Console.ReadLine();
        subStringInText(subString, mainString);
    }

    static void subStringInText(string subString, string mainString)
    {
        int substringlength = subString.Length;
        int counter = 0;
        for (int i = 0; i <= mainString.Length - substringlength; i++)
        {
            string currentSubString = mainString.Substring(i, substringlength);
            if (currentSubString.Equals(subString, StringComparison.CurrentCultureIgnoreCase))
            {
                counter++;
            }
        }
        Console.WriteLine(counter);
    }
}

