using System;

class simpleWhileTriangle3
{
    static void Main()
    {
        int column = 1;
        while (column <= 5)
        {
            int row = 5;
            while (row >= 1)
            {
             if (row <= column)
                {
                    
                    Console.Write("{0} ", row);
                }
                else
                {
                    Console.Write("  ");
                }
            
            --row;
            }

            Console.WriteLine();
            ++column;
        }
    }
}

