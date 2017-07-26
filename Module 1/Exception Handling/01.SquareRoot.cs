using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            double number = double.Parse(Console.ReadLine());
            Convert.ToUInt32(number);
            int result = 1;
            result /= Convert.ToInt32(number);
            number = SquareRoot(number);
            Console.WriteLine("{0:0.000}", Math.Round(number, 3, MidpointRounding.AwayFromZero));
        }
        catch (ArithmeticException)
        {
            Console.WriteLine("Invalid number");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number");
        }
        finally
        {
            Console.WriteLine("Good bye");
        }

    }

    public static double SquareRoot(double number)
    {
        number = Math.Sqrt(number);
        return number;
                        
    }
}

