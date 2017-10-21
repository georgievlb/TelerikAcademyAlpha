using System;

class BonusPoints
{
    static void Main()
    {
        Console.WriteLine("Enter points between 0-9: ");
        int points = int.Parse(Console.ReadLine());
        switch (points)
        {
            case 0:
                Console.WriteLine("Error. No points!");
                break;
            case 1:
            case 2:
            case 3:
                Console.WriteLine("x 10 BBBBONUS! You got {0} points!", points * 10);
                break;
            case 4:
            case 5:
            case 6:
                Console.WriteLine("x 100 BBBBBBONNUS! You got {0} points", points * 100);
                break;
            case 7:
            case 8:
            case 9:
                Console.WriteLine("x 1000 MEGA BONUS! You got {0} points", points * 1000);
                break;
            default:
                Console.WriteLine("Error. No points!");
                break;
        }
    }
}

