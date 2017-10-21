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
        static List<int> Swap(List<int> numbersList, int swap)
        {

            List<int> temp = new List<int>();
            //Console.WriteLine($"Swap number = {swap}");
            var found = numbersList.IndexOf(swap);
            //Console.WriteLine("Original sequence:");
            //Console.WriteLine(string.Join(" ", numbersList));

            //cut items before and after swap number

            for (int j = 0; j < numbersList.IndexOf(swap); j++)
            {
                temp.Add(numbersList[j]);
            }
            
            while (numbersList.IndexOf(swap) != 0)
            {
                numbersList.RemoveAt(0);
            }
            numbersList.RemoveAt(0);
            //Console.WriteLine("Numbers before and after swap number:");
            //Console.WriteLine(string.Join(" ", temp));
            //Console.WriteLine(string.Join(" ", numbersList));

            //add numbers after swap

            numbersList.Add(swap);
            numbersList.AddRange(temp);
            //foreach (var number in temp)
            //{
            //    numbersList.Add(number);
            //}
            //temp.RemoveRange(0, temp.Count);
            //Console.WriteLine("New sequence:");
            //Console.WriteLine(string.Join(" ", numbersList));
            //Console.WriteLine($"Number of items in temporary list: {temp.Count}");

            //Console.WriteLine("####################\n\n");

            return numbersList;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var sequence = Enumerable.Range(1, n);
            List<int> numbersList = new List<int>(sequence);
            int[] swapNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < swapNumbers.Length; i++)
            {
                Swap(numbersList, swapNumbers[i]);
            }
            Console.WriteLine(string.Join(" ", numbersList));


        }
    }
}
