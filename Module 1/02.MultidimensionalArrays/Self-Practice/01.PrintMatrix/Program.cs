using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultidimensionalArrays;

namespace MultidimensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = 
            {
                {2, 5, 9, 1},
                {8, 9, 4, 2},
                {6, 4, 1, 3},
                {3, 8, 0, 7}

            };

            MatrixOperations.PrintMatrix(matrix);
            int[,] matrix2 = new int[4, 4];
            MatrixOperations.FillMatrix(matrix2);
            MatrixOperations.PrintMatrix(matrix2);
        }
    }
}
