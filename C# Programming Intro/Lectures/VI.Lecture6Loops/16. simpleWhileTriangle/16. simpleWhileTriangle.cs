using System;

class Program
{
    static void Main()
    {
        int column = 1;
        while (column <= 5)
        {
            int row = 1;
            while (row < column)
            {
                Console.Write("{0} ", row);
                ++row;

            }
            Console.WriteLine("{0}", column);
            ++column;
            
        }
    }
}

