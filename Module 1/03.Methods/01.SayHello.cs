using System;

class SayHello
{
    static void Main()
    {
        printName();
    }

    static string printName()
    {
        string name = Console.ReadLine();
        Console.WriteLine("Hello, {0}!", name);
        return name;
    }
}
