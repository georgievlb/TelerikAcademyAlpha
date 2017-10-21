using System;

class compareTwoNumbers
{
    static void Main()
    {
        Console.Write("Enter number of integers for input: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("You have entered {0}. Please enter {1} integers: ", n, n);
        
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter a number: ");
            int a = int.Parse(Console.ReadLine());
            int min = a;
            int max = 0;
            if (min < max)
            {
                Console.WriteLine("{0} is lesser", min);
            }
            else
            {
                Console.WriteLine("{0} is lesser", max);
            }
       
            
        }
        
    }
}

