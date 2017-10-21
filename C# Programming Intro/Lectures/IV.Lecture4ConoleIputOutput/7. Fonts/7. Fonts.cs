using System;
using System.Text;

class Fonts
{
    static void Main()
    {
        //Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Green;
        //copyright symbol
        Console.WriteLine("\u00A9");
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Това е кирилица \u00A9");
        Console.WriteLine(
            "Това е хит" +
            "и това е хит" +
            "и това де"
                    );
        //ТАЗИ ПРОГРАМА Е ХИТЪР НАЧИН ДА ИЗПОЛЗВАМЕ УСЛОВИЕ БЕЗ IF ИЛИ УСЛОВЕН ИЗРАЗ
        Console.WriteLine("This program calculates " + "the area of a rectangle or a triangle");

        Console.WriteLine("Enter a and b (for rectangle) " + " or a and h (for triangle): ");

        int a = 0;

        while (true)
        {
            string aAsString = Console.ReadLine();
            if (int.TryParse(aAsString, out a))
            {
                break;
            }
        }

        int b = 0;
        while (true)
        {
            string bAsString = Console.ReadLine();
            if (int.TryParse(bAsString, out b))
            {
                break;
            }
        }




        Console.Write("Enter 1 for a rectangle or 2 " + "for a triangle: ");

        int choice = int.Parse(Console.ReadLine());
        double area = (double) (a * b) / choice;
        Console.WriteLine("The area of your figure " + " is {0}", area);
    }
}
