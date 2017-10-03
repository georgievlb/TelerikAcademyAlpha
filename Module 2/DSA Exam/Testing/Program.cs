using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;


namespace OrdersSystem
{
    class Program
    {
        private class Food : IComparable<Food>
        {
            public string FoodName { get; set; }
            public int FoodWeight { get; set; }
            public int FoodValue { get; set; }

            public Food(string foodName, int foodWeight, int foodValue)
            {
                this.FoodName = foodName;
                this.FoodWeight = foodWeight;
                this.FoodValue = foodValue;
            }

            public int CompareTo(Food other)
            {
                var result = this.FoodWeight.CompareTo(other.FoodWeight);
                if (result == 0)
                {
                    result = this.FoodValue.CompareTo(other.FoodValue);
                }
                return result;
            }

            public override string ToString()
            {
                return string.Format($"{FoodName}\t {FoodWeight} grams {FoodValue} protein");
            }
        }

        public static int KnapSack(int capacity, int[] weight, int[] value, int itemsCount)
        {
            int[,] K = new int[itemsCount + 1, capacity + 1];

            for (int i = 0; i <= itemsCount; ++i)
            {
                for (int w = 0; w <= capacity; ++w)
                {
                    if (i == 0 || w == 0)
                        K[i, w] = 0;
                    else if (weight[i - 1] <= w)
                        K[i, w] = Math.Max(value[i - 1] + K[i - 1, w - weight[i - 1]], K[i - 1, w]);
                    else
                        K[i, w] = K[i - 1, w];
                }
            }

            return K[itemsCount, capacity];
        }

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

        static void PrintMatrix(bool[,] matrix, int rows, int cols)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (col != col - 1)
                        Console.Write((matrix[row, col]) + " ");

                    else
                        Console.Write(matrix[row, col]);

                }
                Console.WriteLine();
            }
        }//end of prin

        static void Main()
        {
            OrderedBag<Food> foodList = new OrderedBag<Food>();
            foodList.Add(new Food("beans", 8, 13));
            foodList.Add(new Food("tofu", 1, 4));
            foodList.Add(new Food("nuts", 4, 5));
            foodList.Add(new Food("quinoa", 8, 12));
            foodList.Add(new Food("veggies", 2, 3));
            foodList.Add(new Food("lentils", 3, 2));


            int capacity = 10;

            int[,] foodMatrix = new int[foodList.Count + 1, capacity + 1];
            bool[,] foodsToPick = new bool[foodList.Count + 1, capacity + 1];
            string food1 = null;
            var foodNames = new List<string>();
            for (int rows = 0; rows <= foodList.Count; rows++)
            {
                for (int cols = 0; cols <= capacity; cols++)
                {
                    if (rows == 0 || cols == 0)
                    {
                        foodMatrix[rows, cols] = 0;
                    }
                    else if (foodList[rows - 1].FoodWeight <= cols)
                    {
                        //var result = foodMatrix[rows, cols] =
                        //    Math.Max(
                        //    foodList[rows - 1].FoodValue + foodMatrix[rows - 1, cols - foodList[rows - 1].FoodWeight],
                        //    foodMatrix[rows - 1, cols]);
                        //Console.WriteLine(result);
                        //foreach (var element in foodList)
                        //{
                        //    if (element.FoodValue == result && !foodNames.Contains(element.FoodName))
                        //        foodNames.Add(element.FoodName);
                        //}
                        foodMatrix[rows, cols] =
                            Math.Max(
                            foodList[rows - 1].FoodValue + foodMatrix[rows - 1, cols - foodList[rows - 1].FoodWeight],
                            foodMatrix[rows - 1, cols]);
                        foodsToPick[rows, cols] = true;


                        if (foodList[rows - 1].FoodValue < foodMatrix[foodList.Count, capacity])
                        {
                            food1 = foodList[rows - 1].FoodName; //this shows beans
                        }

                    }
                    else
                    {
                        foodMatrix[rows, cols] = foodMatrix[rows - 1, cols];
                        foodsToPick[rows, cols] = false;
                    }
                    //if (foodMatrix[rows,cols] == foodList[rows].FoodValue)
                    //    Console.WriteLine("yes " + foodList[rows].FoodValue);
                }
            }
            Console.WriteLine(foodMatrix[foodList.Count, capacity]);
            int weight = 10;
            int currentItem = 6;

            PrintMatrix(foodMatrix, 7, 11);
            PrintMatrix(foodsToPick, 7, 11);
            //Console.WriteLine(food1);
            //foodNames.Reverse();
            //Console.WriteLine(string.Join("\n", foodNames));

            //foreach (var element in foodList)
            //{
            //    Console.WriteLine(element.FoodValue);
            //}
        }


    }
}
