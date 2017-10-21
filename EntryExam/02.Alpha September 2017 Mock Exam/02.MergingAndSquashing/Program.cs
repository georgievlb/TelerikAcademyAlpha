using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _02.MergingAndSquashing
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] numbers = new string[N];
            for (int i = 0; i < N; i++)
            {
                numbers[i] = Console.ReadLine();
            }
            string[] merged = new string[N - 1];
            for (int i = 0; i < merged.Length; i++)
            {
                string ab = numbers[i];
                string cd = numbers[i + 1];
                merged[i] = string.Concat(ab[1].ToString() + cd[0].ToString());
            }

            string[] squashed = new string[N - 1];
            for (int i = 0; i < squashed.Length; i++)
            {
                string ab = numbers[i];
                string cd = numbers[i + 1];
                int middleNumber = int.Parse(ab[1].ToString()) + int.Parse(cd[0].ToString());
                if (middleNumber > 9)
                {
                    middleNumber = middleNumber % 10;
                }
                squashed[i] = string.Concat(ab[0].ToString() + middleNumber.ToString() +cd[1].ToString());
            }

            Console.WriteLine(string.Join(" ", merged));
            Console.WriteLine(string.Join(" ", squashed));
        }
    }
}
