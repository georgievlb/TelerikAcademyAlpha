using System;

class intParseString
{
    static void Main()
    {
        //Особеност тук е, че разчитаме, че потребителят ще въведе числа а не други символи
        //може и long.Parse(string)
        //OR Convert.ToInt32(ReadLine());
        string firstNumber = Console.ReadLine();
        int number1 = int.Parse(firstNumber);
        string secondNumber = Console.ReadLine();

        int number2 = int.Parse(secondNumber);
        Console.WriteLine(number1 + number2);
        Console.WriteLine();
        //OR
        Console.WriteLine("{0} + {1} = {2}", number1, number2, number1 + number2);
        Console.WriteLine("{0} * {1} = {2}", number1, number2, number1 * number2);
    }
}

