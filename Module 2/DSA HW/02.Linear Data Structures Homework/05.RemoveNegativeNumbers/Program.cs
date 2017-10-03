using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.RemoveNegativeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 19, -10, 12, -6, -3, 34, -2, 5 };
            List<int> positiveList = new List<int>();
            //list.RemoveAll(x => x < 0); това е бавно за списъци, както и RemoveAt
            //foreach (var element in list)
            //{
            //    Console.Write("{0,3}", element);
            //}
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > 0)
                {
                    positiveList.Add(list[i]);
                }
            }
            
            foreach (var element in positiveList)
            {
                Console.Write("{0,3}", element);
            }
        }
    }
}
