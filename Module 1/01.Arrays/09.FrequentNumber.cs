using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 11, 90, 2, 35, 2, 2, 0, -1, -2};
            int currentMostFrequent = 0;
            int counter = 1;
            currentMostFrequent = arr[0];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                
                if (currentMostFrequent == arr[i+1])
                {
                    counter++;
                }

            }
            Console.WriteLine(counter);
        }
    }
}
