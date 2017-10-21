using System;

namespace programka
{
    //class userInput
    //{
    //    public Int32 enterNumber()
    //    {
    //        //This function uses TryParse to check if user has entered a valid integer
    //        int a = 0;
    //        Console.WriteLine("Enter a number: ");
    //        while (true)
    //        {
                
    //            string aAsString = Console.ReadLine();
    //                if (int.TryParse(aAsString, out a))     //if TryParse is successful, move the value to a
    //                {
    //                break;          //pri uspeshno parsvane spirash cikula
    //                }
    //                    else 
    //                    {
    //                    Console.WriteLine("Enter a valid number: ");    //pri neuspeshno parsvane, pochvash cikula
    //                    continue;
    //                    }
    //      }
    //        return a;
    //    }
    //}

    class Program
    {
        static void Main()
        {
            var b = int.Parse(Console.ReadLine());
            
            int value1 = b.enterNumber();
            int value2 = b.enterNumber();
            var value3 = b.enterNumber();
            var value4 = b.enterNumber();
            var value5 = b.enterNumber();

    
            Console.WriteLine(value1 + value2 + value3 + value4 + value5);
            
        }
    }

}