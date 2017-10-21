using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.DirectedGraph
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectedGraph graph = new DirectedGraph();
            graph.InsertVertex("xyz");
            graph.InsertVertex("pqr");
            graph.InsertVertex("lmn");
            graph.InsertVertex("abc");

            graph.Display();
        }
    }
}
