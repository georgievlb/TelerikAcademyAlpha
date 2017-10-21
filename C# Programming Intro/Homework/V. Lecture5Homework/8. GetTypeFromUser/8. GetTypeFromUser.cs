using System;

class GetTypeFromUser
{
    static void Main()
    {
        Console.WriteLine("Enter a variable: press 0 for int, 1 for double or 2 for string");
        int a = Convert.ToInt32(Console.ReadLine());
        switch (a)
        {
            case 0:
                Console.WriteLine("Enter an integer: ");
                int number1 = int.Parse(Console.ReadLine());
                Console.WriteLine("{0} + 1 = {1}", number1, number1 + 1 );
                break;
            case 1:
                Console.WriteLine("Enter a variable from type double: ");
                double number = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("{0} + 1 = {1} ", number, number + 1);
                break;
            case 2:
                Console.WriteLine("Enter a string: ");
                string userInput = Console.ReadLine();
                Console.WriteLine("{0}" + "*", userInput);
                break;
            default:
                Console.WriteLine("Bad input, program closing.");
                break;
        }
        //dynamic s = Console.ReadLine();
        //Type type = s.GetType();
        //object d = Console.ReadLine();
        //Type type2 = d.GetType();
        //Console.WriteLine(type);
        //Console.WriteLine(type2);
        //Type type3 = typeof(int);
        //Console.WriteLine(type3);
    }
}

