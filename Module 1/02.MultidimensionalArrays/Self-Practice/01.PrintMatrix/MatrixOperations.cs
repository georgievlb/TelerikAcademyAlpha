using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultidimensionalArrays
{
    public class MatrixOperations
    {
        public static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0, 3}", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        public static int[,] FillMatrix(int[,] matrix)
        {
            Console.WriteLine("Enter the cells of the matrix:");
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("matrix[{0},{1}] = ", row, col);
                    matrix[row, col] = int.Parse(Console.ReadLine());
                }
            }

            return matrix;
        }
    }
}
