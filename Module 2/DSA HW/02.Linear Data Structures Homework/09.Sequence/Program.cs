using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            int n = int.Parse(Console.ReadLine());
            queue.Enqueue(n);
            
            for (int i = 0; i < 51; i++)
            {
                queue.Enqueue(queue.ElementAt(i) + 1);
                queue.Enqueue(2 * queue.ElementAt(i) + 1);
                queue.Enqueue(queue.ElementAt(i) + 2);
            }
            while(queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }
        }
    }
}
