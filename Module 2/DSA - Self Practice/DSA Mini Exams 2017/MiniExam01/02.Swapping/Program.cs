using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace _02.Swapping
{
    class Program
    {
        static void Main(string[] args)
        {
            var sequence = Enumerable.Range(1, 12);
            BigList<int> numbersList = new BigList<int>(sequence);
            BigList<int> temp = new BigList<int>();
            int[] swapNumbers = new int[] { 11, 5, 10, 6, 9, 10 };
            int i = 0; //TODO - REMOVE
            int swap = swapNumbers[i];
            //int swap = 15;
            Console.WriteLine($"Swap number = {swap}");
            var found = numbersList.IndexOf(swap);
            Console.WriteLine("Original sequence:");
            Console.WriteLine(string.Join(" ", numbersList));

            //cut items before and after swap number

            for (int j = 0; j < numbersList.IndexOf(swap); j++)
            {
                temp.Add(numbersList[j]);
            }

            while (numbersList[0] != swap + 1)
            {
                numbersList.RemoveAt(0);
            }

            Console.WriteLine("Numbers before and after swap number:");
            Console.WriteLine(string.Join(" ", temp));
            Console.WriteLine(string.Join(" ", numbersList));

            //add numbers after swap

            numbersList.Add(swap);
            foreach (var number in temp)
            {
                numbersList.Add(number);
            }
            temp.RemoveRange(0, temp.Count);
            Console.WriteLine("New sequence:");
            Console.WriteLine(string.Join(" ", numbersList));
            //Console.WriteLine($"Number of items in temporary list: {temp.Count}");

            Console.WriteLine("END OF ROUND\n\n");


        }
    }
}
