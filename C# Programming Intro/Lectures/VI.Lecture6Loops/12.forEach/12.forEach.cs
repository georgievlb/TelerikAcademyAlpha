using System;

class Program
{
    static void Main()
    {
        //for each za vseki student v tazi zala - dau mu kontrolno
        string[] days =
        {
            "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        foreach (string day in days)
        {
            Console.WriteLine(day);
        }
    }
}

