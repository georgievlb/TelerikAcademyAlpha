using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.VeganBodubuilder
{
    class Program
    {
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

        static void Main(string[] args)
        {//sorted by key


            SortedDictionary<int, int> foodInfo = new SortedDictionary<int, int>();
            Dictionary<int, string> foodName = new Dictionary<int, string>();
            //key = weight
            foodInfo.Add(8, 13);//beans
            foodName.Add(8, "beans");
            foodInfo.Add(1, 4);//tofu
            foodName.Add(1, "tofu");
            foodInfo.Add(4, 5);//nuts
            foodName.Add(4, "nuts");
            foodInfo.Add(2, 3);//veggies
            foodName.Add(2, "veggies");
            foodInfo.Add(8, 12);//quinoa
            foodName.Add(2, "quinoa");
            foodInfo.Add(3, 2);//lentils 
            foodName.Add(2, "lentils");

            foreach (var foodInfoKey in foodInfo.Keys)
            {
                foreach (var foodNameKey in foodName.Keys)
                {
                    if (foodInfoKey == foodNameKey)
                    {
                        Console.WriteLine($" {foodNameKey} {foodName[foodNameKey]} {foodInfo[foodInfoKey]}");
                    }
                }
            }
            int[,] foodMatrix = new int[6, 11];


            for (int rows = 0; rows < foodMatrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < foodMatrix.GetLength(1); cols++)
                {
                    if (rows == 0)
                    {

                        if (cols < foodInfo.ElementAt(rows).Key)
                        {
                            foodMatrix[rows, cols] = 0;//тук е място за частичен случай/грешка
                        }
                        else
                        {
                            foodMatrix[rows, cols] = foodInfo.ElementAt(rows).Value;
                        }
                    }


                    //да направим така, че foodInfo.Element(0) да се мени
                    else
                    {

                        if (cols == 0)
                        {
                            //  if (foodInfo.ElementAt(rows).Key > cols)

                            foodMatrix[rows, cols] = 0;

                        }
                        else

                        {
                            if (cols - foodInfo.ElementAt(rows).Key < 0)
                                foodMatrix[rows, cols] = Math.Max(
                                foodMatrix[rows, cols - 1],
                                foodMatrix[rows - 1, cols]);
                            //Console.WriteLine("rows=" + rows);
                        }
                    }
                }

            }



            PrintMatrix(foodMatrix, 6, 11);
        }
    }
}