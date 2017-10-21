using System;

class TryParse
{
    static void Main()
    {
        string str = Console.ReadLine();
        int number;
        // out кара функцията Тry.Parse да има правото да запише нещо в промелнивата number
        if (int.TryParse(str, out number))
        {
            Console.WriteLine("Valid Number: {0}", number);
        }
        else
        {
            Console.WriteLine("Invalid Number: {0}", str);
        }

    }
}


