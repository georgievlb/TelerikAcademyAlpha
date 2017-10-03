using System;
using System.Linq;

namespace GoldFever
{
    class Program
    {
        static void Main(string[] args)
        {
            int.Parse(Console.ReadLine());
            int[] days = Console.ReadLine().Split().Select(int.Parse).ToArray();
            long profit = 0;
            int currentProfit = 0;
            
            for (int i = days.Length - 1; i > -1; i--)
            {
                if (days[i] > currentProfit)
                {
                    currentProfit = days[i];
                }
                profit += currentProfit - days[i];
            }
            Console.WriteLine(profit);
        }
    }
}