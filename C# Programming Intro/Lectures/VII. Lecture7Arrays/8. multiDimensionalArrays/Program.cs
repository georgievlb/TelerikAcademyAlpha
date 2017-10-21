using System;

class Program
{
    static void Main()
    {
        int[,] twoDimensionalArray =
        {
            {1, 3, 5, 7, 9},
            {2, 4, 6, 8, 10}

        };

        int rows = twoDimensionalArray.GetLength(0);
        int columns = twoDimensionalArray.GetLength(1);
        
        Console.WriteLine("This array has {0} rows and {1} columns, ", rows, columns);
        
        for (int row = 0; row < rows; row++)
        {
            for (int column = 0; column < columns; column++)
            {
                Console.Write(twoDimensionalArray[row, column] + " ");
            }
            Console.WriteLine();
        }
    }
}
