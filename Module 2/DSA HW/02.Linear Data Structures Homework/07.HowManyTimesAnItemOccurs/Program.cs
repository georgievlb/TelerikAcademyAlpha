using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.RemoveOddRepetitionsofN
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 3, 4, 4, 2, 3, 3, 4, 3, 2 };
            List<int> list2 = new List<int>();
            int index = 0;
            int j = 0;
            StringBuilder builder = new StringBuilder();
            while (index < list.Count)
            {
                int currentItem = list[index];
                int currentItemOccurrence = 0;
                for (int i = 0; i < list.Count; i++)
                {
                    if (currentItem == list[i])
                    {
                        currentItemOccurrence++;
                    }
                }
                if (!list2.Contains(currentItem))
                {
                    list2.Add(currentItem);
                    
                    builder.Append(list2[j] + " found " + currentItemOccurrence + " times\n");
                    j++;
                }
                index++;
            }
            Console.WriteLine(builder.ToString());
        }
    }
}
