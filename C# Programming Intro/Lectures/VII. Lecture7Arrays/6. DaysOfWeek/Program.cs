using System;

class Program
{
    static string[] minutesInHour;// null masiv
    static string[] monthsOfYear = { }; // prazen masiv 
    static void Main(string[] args)
    {
        string[] daysOfWeek = {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"
        };
        Console.WriteLine(daysOfWeek.Length);
        for (int i = 0; i < daysOfWeek.Length; i++)
        {
            Console.WriteLine(daysOfWeek[i]);
        }
    }
}

