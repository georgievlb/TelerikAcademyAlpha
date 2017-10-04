using System;

class Program
{
    static void Main(string[] args)
    {
        string inputText = Console.ReadLine();
        string findSlashes = "://";
        int indexOfFindSlashes = inputText.IndexOf(findSlashes);
        string helpingString = inputText.Substring(indexOfFindSlashes + 3);

        string protocol = (inputText.Substring(0, inputText.IndexOf(findSlashes)));
        string server = helpingString.Substring(0, helpingString.IndexOf("/"));
        string resource = inputText.Substring( (inputText.IndexOf("/", 9)) );

        Console.WriteLine("[protocol] = {0}", protocol);
        Console.WriteLine("[server] = {0}", server);
        Console.WriteLine("[resource] = {0}", resource);
    }
}

