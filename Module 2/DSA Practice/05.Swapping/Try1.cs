//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _05.Swapping
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int n = int.Parse(Console.ReadLine());
//            var numbers = Enumerable.Range(1, n).
//                ToList();

//            var swapNumbers = Console.ReadLine()
//                .Split()
//                .Select(int.Parse)
//                .ToArray();

//            foreach (var number in swapNumbers)
//            {
//                int index = numbers.IndexOf(number);
//                numbers.Insert(0, number);
//                numbers.InsertRange(0, numbers.GetRange(index + 2,
//                    numbers.Count - index - 2));      //даваме индекс
//                numbers.RemoveRange(n, numbers.Count - n);
//            }

//            Console.WriteLine(string.Join(" ", numbers));
//        }
//    }
//}
