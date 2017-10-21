using System;

class Program
{
    static void Main()
    {
        //"X"- означава hexadecimal
        //"C" - currency
        //"0.00"
        //string alpha = "Mnogo alpha";
        //string beta = " Mnogo beta";
        //string gamma = "az sum " + alpha + beta;
        //Console.WriteLine(gamma);

        //int age = 20;
        //concatenate + print on console
        //strings are concatenated from left to right
        //string text = "He is " + age + " years old.";
        //Console.WriteLine(text);
        //double pi = 3.1415926535897932384626433832795028841971693993751d;
        //Console.WriteLine("pi = {0:F2}", pi);   //закръгля до 2-я знак след запетаята

        //Console.WriteLine("{0:C2}", 123.456);   //123.46 лв.
        //Console.WriteLine("{0:D6}", -1234);     //-001234
        //Console.WriteLine("{0:E3}", 123);       //1,23E+002
        //Console.WriteLine("{0:F2}", -123, 456);  //-123,46
        //Console.WriteLine("{0:N2}", 1234567.8); //1 234 567,80!!!! проучи защо не се получава- защото нямаше инсталиран български на windowsa
        //Console.WriteLine("{0:P}", 0.456);      //45.60%
        //Console.WriteLine("{0:X}", 254);        //FE
        //double pi = 1.234;
        //Console.WriteLine("{0:0.000000}", pi);  //1,234000
        ////razdelitel mejdu drobnata i cqlata chast e zapetaq - ,


        double colaPrice = 1.20;
        string cola = "Coca Cola";
        double fantaPrice = 1.20;
        string fanta = "Fanta Dizzy";
        double zagorkaPrice = 1.50;
        string zagorka = "Zagorka";

        Console.WriteLine("Menu:");
        Console.WriteLine("1. {0, -15} | {1,10:C}", cola, colaPrice);
        Console.WriteLine("2. {0, -15} | {1,10:C}", fanta, fantaPrice);
        Console.WriteLine("3. {0, -15} | {1,10:C}", zagorka, zagorkaPrice);

        //Console.WriteLine("{0,-15} | {1,10:F2}   |", cola, colaPrice);
        //Console.WriteLine("The hex value of {0} is {0:X}", 32378 );

        //double someVar = 0.53455432;
        //Console.WriteLine("{0:.000}", someVar);
    }
}

