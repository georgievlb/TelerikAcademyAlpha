using System;

class Operators
{
    static void Main()
    {
        // pri chisla znak + vryshta sbor, a pri nizove - konkatenacia
        //int a = 7 + 9;
        //Console.WriteLine(a);

        //string firstName = "Ala";
        //string secondName = "Bala";

        //string fullName = firstName + " " + secondName;
        //Console.WriteLine(fullName);
        // programata ot 30 day challenge za meals...pogledni kak se zakruglqva nakraq da ne e 12.5 a da e 13
        double mealCost;
        mealCost = Convert.ToDouble(Console.ReadLine());

        double tip;
        tip = Convert.ToDouble(Console.ReadLine());


        double tax;
        tax = Convert.ToDouble(Console.ReadLine());
    
        double totalCost;
        totalCost = mealCost * tip / 100.0 + mealCost * tax / 100.0 + mealCost;

        totalCost = Math.Round(totalCost,
            MidpointRounding.AwayFromZero);
        Console.WriteLine(totalCost);
    }


}


