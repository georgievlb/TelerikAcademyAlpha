using System;

class SequenceInMatrix
{
    static void Main(string[] args)
    {
        string[] matrixSize = Console.ReadLine().Split();
        int n = int.Parse(matrixSize[0]);
        int m = int.Parse(matrixSize[1]);
        int[,] matrix = new int[n, m];

        FillMatrix(matrix, n, m);
        //Console.WriteLine(Right(matrix, 0, 0));
        //PrintMatrix(matrix, n, m);
        int rows = 0;
        int cols = 0;
        int starterElement = matrix[rows, cols];
        int totalCounter = 0;
        int currentCounter = 1;
        for (int col = cols; col < matrix.GetLength(1) - 1; col++)
        {
            if (matrix[rows, col] == matrix[rows, col + 1])
            {
                currentCounter++;
                if (currentCounter > totalCounter)
                    totalCounter = currentCounter;
            }
            totalCounter = currentCounter;
            currentCounter = 0;
        }
        Console.WriteLine("Number of equal elements: " + totalCounter);
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

    static int Right(int[,] matrix, int rows, int cols)
    {
        int starterElement = matrix[rows, cols];
        int counter = 1;
        for (int col = cols; col < matrix.GetLength(0) - 1; col++)
        {
            if (matrix[rows, col] == matrix[rows, col + 1])
            {
                counter++;
                Console.WriteLine("Counter increment: ");
            }
        }
        return counter;
    }
}

