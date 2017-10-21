using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 7;      //number of devs
            int[,] devs = new int[n, n];
            Graph graph = new Graph(devs);
            int m = 5;
            int numberOfKnownColleagues = 0;
            List<int> listOfPairs = new List<int>();
            int[,] arrayOfPairs = new int[m, 2]; //2 means a pair
            for (int i = 0; i < m; i++)
            {                
                string[] verticesToAdd = Console.ReadLine().Split(' ');
                graph.AddEdge(int.Parse(verticesToAdd[0]), int.Parse(verticesToAdd[1]));
                numberOfKnownColleagues++;
                listOfPairs.Add(int.Parse(verticesToAdd[0]));
                listOfPairs.Add(int.Parse(verticesToAdd[1]));
            }
            int k = 0;  //iterates the vertices from the list
            for (int i = 0; i < arrayOfPairs.GetLength(0); i++)
            {
                for (int j = 0; j < arrayOfPairs.GetLength(1); j++)
                {
                    arrayOfPairs[i, j] = listOfPairs[k];
                    k++;
                }
            }
            graph.Display();
            //graph.AddEdge(0, 2);
            //graph.AddEdge(0, 3);
            //graph.AddEdge(1, 4);
            Console.WriteLine(numberOfKnownColleagues);
            //print the array with all the vertices
            for (int row = 0; row < arrayOfPairs.GetLength(0); row++)
            {
                for (int col = 0; col < arrayOfPairs.GetLength(1); col++)
                {
                    Console.Write("{0, 3}", arrayOfPairs[row, col]);
                }
                Console.WriteLine();
            }

            for (int rows = 0; rows < m ; rows++)//rows==5
            {
                for (int cols = 0; cols < 2; cols++)
                {
                    int vertex1 = arrayOfPairs[rows, 0];
                    int vertex2 = arrayOfPairs[rows, 1];
                    for (int row1 = rows + 1; row1 < m; row1++)
                    {
                        for (int col1 = 0; col1 < 2; col1++)
                        {
                            if(arrayOfPairs[rows,cols] == arrayOfPairs[row1,col1])
                            {
                                if (col1 % 2 == 0)
                                {
                                    graph.AddEdge(vertex2, arrayOfPairs[row1, col1 + 1]);
                                }
                                else
                                {
                                    graph.AddEdge(vertex1, arrayOfPairs[row1, col1 - 1]);
                                }
                            }
                        }
                    }
                }
            }

            graph.Display();
            
        }

        
    }
}
