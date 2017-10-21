using System;
using System.Collections.Generic;
using Wintellect.PowerCollections;

namespace JediMeditation
{
    class Program
    {
        static void Main(string[] args)
        {
            BigList<string> totalJedi = new BigList<string>();
            Queue<string> knights = new Queue<string>();
            List<string> padawans = new List<string>();
            int n = int.Parse(Console.ReadLine());
            string[] jedis = Console.ReadLine().Split();

            for (int i = 0; i < n; i++)
            {
                string temp = jedis[i];
                switch (temp[0])
                {

                    case 'M':
                        totalJedi.Add(jedis[i]);
                        break;
                    case 'K':
                        knights.Enqueue(jedis[i]);
                        break;
                    case 'P':
                        padawans.Add(jedis[i]);
                        break;
                    default:
                        break;
                }
            }
            while (knights.Count != 0)
                totalJedi.Add(knights.Dequeue());

            foreach (var padawan in padawans)
            {
                totalJedi.Add(padawan);
            }

            Console.WriteLine(string.Join(" ", totalJedi));
        }
    }
}