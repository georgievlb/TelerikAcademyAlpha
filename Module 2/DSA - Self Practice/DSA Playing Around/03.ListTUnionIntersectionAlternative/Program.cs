using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ListTUnionIntersectionAlternative
{
    class Program
    {
        public static void PrintList(List<int> list)
        {
            Console.Write("{ ");
            foreach (var item in list)
            {
                Console.Write(item);
                Console.Write(" ");
            }
            Console.WriteLine("}");
        }

        public static void Main()
        {
            List<int> firstList = new List<int>();
            firstList.Add(1);
            firstList.Add(2);
            firstList.Add(3);
            firstList.Add(4);
            firstList.Add(5);
            Console.Write("firstList = ");
            PrintList(firstList);

            List<int> secondList = new List<int>();
            secondList.Add(2);
            secondList.Add(4);
            secondList.Add(6);
            Console.Write("secondList = ");
            PrintList(secondList);

            List<int> unionList = new List<int>();
            unionList.AddRange(firstList);
            for (int i = unionList.Count - 1; i >= 0; i--)
            {
                if (secondList.Contains(unionList[i]))
                {
                    unionList.RemoveAt(i);
                }
            }
            unionList.AddRange(secondList);
            Console.Write("union = ");
            PrintList(unionList);

            List<int> intersectList = new List<int>();
            intersectList.AddRange(firstList);
            for (int i = intersectList.Count - 1; i >= 0; i--)
            {
                if (!secondList.Contains(intersectList[i]))
                {
                    intersectList.RemoveAt(i);
                }
            }
            Console.Write("intersect = ");
            PrintList(intersectList);
        }
    }
}
