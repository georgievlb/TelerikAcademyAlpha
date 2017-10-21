using System;

class Strings
{
    static void Main()
    {
        string csharp = "C#";
        string dotnet = ".NET";
        string csharpDotNet = csharp + dotnet;
        Console.WriteLine(csharpDotNet);
        string csharpDotNet4 = csharpDotNet + "" + 4;
        Console.WriteLine(csharpDotNet4);
    }
}

