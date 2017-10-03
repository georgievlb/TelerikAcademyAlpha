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

//            //var qu = new Queue<int>();
//            //for (int i = 1; i <= n; i++)
//            //{
//            //    qu.Enqueue(i);
//            //} това е еквивалентно на

//            var qu = new Queue<int>(Enumerable.Range(1, n));
//            Console.ReadLine()
//                .Split(' ')
//                .Select(int.Parse)
//                .ToList()
//                .ForEach(number =>
//                {
//                    //това е еквивалентно на foreach-a от Try1
//                    qu.Enqueue(number);
//                    int x;
//                    while ((x = qu.Dequeue()) != number)
//                    {
//                        qu.Enqueue(x);
//                    }
//                }
//                );
//            Console.WriteLine(string.Join(" ", qu));


//        }
//    }
//}
