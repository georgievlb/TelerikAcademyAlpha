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
            List<int> list = new List<int>() { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };
            int index = 0;
            
            while (index < list.Count)
            { 
                int currentItem = list[index];
                int currentItemOccurrence = 0;
                for (int i = 0; i < list.Count; i++)
                {
                    if(currentItem == list[i])
                    {
                        currentItemOccurrence++;
                    }
                }
                if (currentItemOccurrence % 2 != 0)
                {
                    list.RemoveAll(x => x == currentItem);
                }
                else
                {
                    index++;
                }
            }
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
