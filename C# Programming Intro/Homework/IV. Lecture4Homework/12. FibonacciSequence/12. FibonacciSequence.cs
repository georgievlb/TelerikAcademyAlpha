using System;

class FibonnacciSequence
{
    static void Main()
    {
        //print the first 15 numbers of the fibonacci sequence
        Console.ForegroundColor = ConsoleColor.Green;
        int n = 15;
        int a = 1;
        int b = 1;
        
        for (int i = 1; i <= n; i++)
        {
            int temp = a;
            a = b;
            b += temp;
            int sum = temp;
            sum += temp; 
            Console.WriteLine("Fibonacci No.{0}: {1}", i, temp);
            
           
            
        }
                      
    }
}

