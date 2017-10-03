//65 points
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersSystem
{
    class Program
    {
        static void Main(string[] args)
        {

            int maxGramsOfFood = int.Parse(Console.ReadLine());        
            int numberOfFoods = int.Parse(Console.ReadLine());
            List<Food> foods = new List<Food>();
            for (int i = 0; i < numberOfFoods; i++)
            {
                string food = Console.ReadLine();
                string[] foodList = food.Split(' ');
                foods.Add(new Food(foodList[0], int.Parse(foodList[1]), int.Parse(foodList[2])));
            }
            VeganBodyBuilderMenu foodMenu = new VeganBodyBuilderMenu();

            List<Food> itemsToBePacked = foodMenu.FindItemsToPack(foods, maxGramsOfFood);
            foreach (var item in itemsToBePacked)
            {
                Console.WriteLine(item);
            }
        }

        private class VeganBodyBuilderMenu
        {
            public List<Food> FindItemsToPack(List<Food> items, int capacity)
            {

                int [,] price = new int[items.Count + 1, capacity + 1];
                bool[,] keep = new bool[items.Count + 1, capacity + 1];
                int totalValueOfItems = 0;
                for (int i = 1; i <= items.Count; i++)
                {
                    Food currentItem = items[i - 1];
                    for (int space = 1; space <= capacity; space++)
                    {
                        if (space >= currentItem.FoodWeight)
                        {
                            int remainingSpace = space - currentItem.FoodWeight;
                            int remainingSpaceValue = 0;
                            if (remainingSpace > 0)
                            {
                                remainingSpaceValue = price[i - 1, remainingSpace];
                            }
                            int currentItemTotalValue = currentItem.FoodValue + remainingSpaceValue;
                            if (currentItemTotalValue > price[i - 1, space])
                            {
                                keep[i, space] = true;
                                price[i, space] = currentItemTotalValue;
                            }
                            else
                            {
                                keep[i, space] = false;
                                price[i, space] = price[i - 1, space];
                            }
                        }
                    }
                }
                List<Food> itemsToBePacked = new List<Food>();
                int remainSpace = capacity;
                int item = items.Count;
                while (item > 0)
                {
                    bool toBePacked = keep[item, remainSpace];
                    if (toBePacked)
                    {
                        itemsToBePacked.Add(items[item - 1]);
                        remainSpace = remainSpace - items[item - 1].FoodWeight;
                    }
                    item--;
                }
                totalValueOfItems = price[items.Count, capacity];
                Console.WriteLine(totalValueOfItems);
                return itemsToBePacked;
            }
        }

        private class Food
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
            public override string ToString()
            {
                return FoodName;
            }
        }
    }
}
