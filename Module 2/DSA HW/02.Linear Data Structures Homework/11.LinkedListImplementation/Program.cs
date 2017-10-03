using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.LinkedListImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleLinkedList list = new SingleLinkedList();
            list.Add(4);
            list.Add(2);
            list.DisplayList();
            Console.WriteLine(list.Count);
        }
    }
}
