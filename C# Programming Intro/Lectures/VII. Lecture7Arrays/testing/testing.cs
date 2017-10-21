using System;

class Program
{
    static void Main()
    {
        //това са двата варианта за инициализиране на масив
        int[] myIntArray;                       //декларация на масив
        myIntArray = new int[5];                //заделяне на (памет за) масив
        int[] myIntArray2 = {1, 2 , 3, 4, 5};   //инициализиране
        string[] daysOfWeek =
        {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"
        };
        for (int i = 0; i < daysOfWeek.Length; i++)
        {
            Console.WriteLine(daysOfWeek[i]);
        }
        
    }
}

