using System;

class Program
{
    static void Main()
    {
        //exit out of infinite loop with break;
        // break has to be inside a bigger loop! not only in the 'if below
        while (true)
        {
            Console.WriteLine("Press any key to continue or 0 to exit: ");
            int test = int.Parse(Console.ReadLine());
            if (test == 0)
            {
                Console.WriteLine("Bye!");
                break;
            }
            
        }
        Console.WriteLine("OK");

    }
}
