using System;

class Program
{
    static void Main()
    {
        //do while cikul - uslovieto e nakraq i vinagi se izpylnqva pone vednuj
        string numberAsString = Console.ReadLine();
        int n = Convert.ToInt32(numberAsString);
        int factorial = 1;

        do
        {
            factorial *= n;
            n--;
        }
        while (n > 0);

        Console.WriteLine("n! = " + factorial);
    }
}
