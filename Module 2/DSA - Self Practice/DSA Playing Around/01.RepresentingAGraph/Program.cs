using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.RepresentingAGraph
{
    class Program
    {
        //void TraverseDFSRecursive(node);

        static void Main(string[] args)
        {
            Graph g = new Graph(new int[][] //освен с масив от масиви, може да се напави и със списък от списъци
            {
                new int[] {3, 6},
                new int[] {2, 3, 4, 5, 6},
                new int[] {1, 4, 5},
                new int[] {0, 1, 5},
                new int[] {1, 2, 6},
                new int[] {1, 2, 3},
                new int[] {0, 1, 4}
            });
        }
    }
}
