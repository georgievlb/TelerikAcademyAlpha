using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            //това е списъчна структура, реализирана чрез масив. Тя е вградена в C#
            ArrayList list = new ArrayList(); 
            list.Add("Hello");
            list.Add(5);
            list.Add(3.14159);
            list.Add(DateTime.Now);

            for (int i = 0; i < list.Count; i++)
            {
                object value = list[i];
                Console.WriteLine(
                "Index={0}; Value={1}\n", i, value);
            }
            //ArrayList with numbers only
            ArrayList list2 = new ArrayList();
            list2.Add(2);
            list2.Add(3);
            list2.Add(4);
            int sum = 0;
            for (int i = 0; i < list2.Count; i++)
            {
                int value = (int)list2[i];
                sum = sum + value;
            }
            Console.WriteLine("Sum = " + sum);
        }
    }
}
