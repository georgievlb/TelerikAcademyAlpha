using System;

class fourDigitNumber
{
    static void Main()
    {
    Console.WriteLine("Enter a four digit number: ");
    int number = Convert.ToInt32(Console.ReadLine());
        int digit4 = number % 10;
        int digit3 = (number % 100)/10;
        int digit2 = (number / 100) % 10;
        int digit1 = number / 1000;
        int sum = digit1 + digit2 + digit3 + digit4;
        //Console.WriteLine(sum);
        Console.WriteLine("{0}{1}{2}{3}", digit4, digit3, digit2, digit1);
        Console.WriteLine("{0}{1}{2}{3}", digit4, digit1, digit2, digit3);
        Console.WriteLine("{0}{1}{2}{3}", digit1, digit3, digit2, digit4);
    }
}

