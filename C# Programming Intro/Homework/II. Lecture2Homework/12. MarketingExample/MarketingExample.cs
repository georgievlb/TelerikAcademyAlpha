using System;

class MarketingExample
{
    static void Main()
    {
        string firstname = "Anthony";
        string lastname = "John";
        char gender = 'm';
        uint id = 27561111;
        //look up how to create a struct;
        Console.WriteLine("Enter your name:");
        string name = Console.ReadLine();
        Console.WriteLine(name);
        int age;
        Console.WriteLine("Enter your age: ");
        age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(age);
    }
}
