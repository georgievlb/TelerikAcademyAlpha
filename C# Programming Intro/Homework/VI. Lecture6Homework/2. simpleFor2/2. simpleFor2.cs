using System;

class simpleFor2
{
    static void Main()
    {
        Console.WriteLine("Enter a number of integers to compare: ");
        int n = int.Parse(Console.ReadLine());
        int min = 0;
        int max = 0;
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Enter a number: ");
            int userInput = int.Parse(Console.ReadLine());
                   

            Console.WriteLine("You entered {0}", userInput);
            if (max < userInput)
            {
                max = userInput;
            }
            if (min > userInput || min == 0)                
            {
                
                min = userInput; 
            }

        }
        Console.WriteLine("min is {0}, max is {1}", min, max);
    }
}

