using System;

class Program
{
    static void Main(string[] args)
    {
        string expression = Console.ReadLine();
        int length = expression.Length;
        int counter = 0;
        int check = 0;
        for (int i = 0; i < length; i++)
        {
            check = expression[i];
            if (check == '(')
            {
                counter++;
            }
            else if (check == ')')
            {
                counter--;
            } 
        }
        if (counter == 0)
            Console.WriteLine("Correct");
        
        else
            Console.WriteLine("Incorrect");
    }    
}
