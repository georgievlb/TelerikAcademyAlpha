using System;

class Program
{
    static void Main()
    {
        int column = 5;
        while (column >= 1)
        {
            int row = column;
            while (row >= 1)
            {
                Console.Write("{0} ", row);
                row--;
            }
            Console.WriteLine();
            --column;
        }
        
    }
}
