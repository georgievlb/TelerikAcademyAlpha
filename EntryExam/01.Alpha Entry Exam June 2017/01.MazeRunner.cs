using System;

class fourDigitNumber
{
    private static string digitChecker(int number)
    {
        
            int digit4 = number % 10;
            int digit3 = (number % 100) / 10;
            int digit2 = (number / 100) % 10;
            int digit1 = number / 1000;
            int sumOdd = 0;
            int sumEven = 0;
            //digit 4 odd or even
            if (digit4 % 2 == 0)
            {
                sumEven += digit4;
            }
            else
            {
                sumOdd += digit4;
            }

            //digit 3 odd or even
            if (digit3 % 2 == 0)
            {
                sumEven += digit3;
            }
            else
            {
                sumOdd += digit3;
            }

            //digit 2 odd or even
            if (digit2 % 2 == 0)
            {
                sumEven += digit2;
            }
            else
            {
                sumOdd += digit2;
            }

            //digit 1 odd or even
            if (digit1 % 2 == 0)
            {
                sumEven += digit1;
            }
            else
            {
                sumOdd += digit1;
            }
         
                    if (sumEven > sumOdd)
                    {
            return "left";
                        
                    }
                    else if (sumOdd > sumEven)
                    {
            return "right";
                     }
                    else if (sumEven == sumOdd)
                    {
            return "straight";
                    }
        return digitChecker(number);
    }


    static void Main()
    {
        
        int number = int.Parse(Console.ReadLine());
        
        for (int i = 1; i <= number; i++)
        {
            int numberNext = int.Parse(Console.ReadLine());
            Console.WriteLine(digitChecker(numberNext));
        }
    }
}

