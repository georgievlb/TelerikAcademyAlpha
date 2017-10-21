using System;

namespace SumNumbersSimplified
{
    class userInput
    {
        public int enterNumber()
        {
            int a;
            a = int.Parse(Console.ReadLine());
            return a;
        }
    }

    class SumNumbersSimplified
    {
        static void Main()
        {
            var b = new userInput();

            int value = b.enterNumber();
            int value2 = b.enterNumber();
            int value3 = b.enterNumber();
            int value4 = b.enterNumber();
            int value5 = b.enterNumber();
            Console.WriteLine(value + value2 + value3 + value4 + value5);


        }
    }
}
