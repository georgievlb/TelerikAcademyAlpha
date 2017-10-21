using System;

class numberOfDigits
{
    static void Main()
    {
        int num = 723;
        //Console.WriteLine(num % 10);
        //Console.WriteLine((num / 10) % 10);
        Console.WriteLine((num /100 == 7) ? "the third digit is 7" : "the third digit is not 7");
    }
}
