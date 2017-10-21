using System;

class Program
{
    static void Main()
    {
        string[] matrixSize;
        int n = 0;
        int m = 0;
        do
        {
            Console.WriteLine("Enter values for n and m: ");
            matrixSize = Console.ReadLine().Split();
            n = int.Parse(matrixSize[0]);
            m = int.Parse(matrixSize[1]);
        }
        while (n < 3 || m > 1024 || n < 0 || m < 0);
        int[,] matrix = new int[n, m];
        Console.WriteLine("Number of rows: " + matrix.GetLength(0));
        Console.WriteLine("Number of columns: " + matrix.GetLength(1));
        FillMatrix(matrix, n, m);
        PrintMatrix(matrix, n, m);
        Console.WriteLine(MaxSumOfMiniMatrix(matrix));
    }

    static void FillMatrix(int[,] matrix, int rows, int cols)
    {
        for (int row = 0; row < rows; row++)
        {
            int i = 0;
            string[] fillMatrix = Console.ReadLine().Split();
            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = int.Parse(fillMatrix[i]);
                i++;
            }
        }
    }// end of FillMatrix()

    static void PrintMatrix(int[,] matrix, int rows, int cols)
    {
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                if (col != col - 1)
                    Console.Write(matrix[row, col] + " ");

                else
                    Console.Write(matrix[row, col]);

            }
            Console.WriteLine();
        }
    }//end of printMatrix()

    static int MaxSumOfMiniMatrix(int[,] matrix)
    {
        int totalSum = int.MinValue;
        int currentSum = int.MinValue;
        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                if (currentSum > totalSum)
                {
                    totalSum = currentSum;
                }
            }
        }
        return totalSum;
    }
}