using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.StaticStackArrayImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomStaticStack stack = new CustomStaticStack();

            stack.Push(3);
            stack.Push(5);
            stack.Push(7);
            stack.Push(9);
            stack.Push(-1);
            stack.Pop();
            stack.ShowStack();
            stack.Peek();
        }
    }
}
