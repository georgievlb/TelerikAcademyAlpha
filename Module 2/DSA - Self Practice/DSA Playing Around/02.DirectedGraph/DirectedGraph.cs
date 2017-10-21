using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.DirectedGraph
{
    public class DirectedGraph//adj matrix
    {
        private readonly int max_vertices = 30;//

        int numberOfVerticesInTheGraph;
        int numberOfEdgesInTheGraph;
        bool[,] adjacencyMatrix;
        Vertex[] vertexList;

        public DirectedGraph()
        {
            adjacencyMatrix = new bool[max_vertices, max_vertices];
            vertexList = new Vertex[max_vertices];
        }

        public int Vertices()
        {
            return numberOfVerticesInTheGraph;
        }

        public int Edges()
        {
            return numberOfEdgesInTheGraph;
        }

        public void Display()//display the adjacency matrix
        {
            for (int i = 0; i < numberOfVerticesInTheGraph; i++)
            {
                for (int j = 0; j < numberOfVerticesInTheGraph; j++)
                {
                    if(adjacencyMatrix[i,j])
                        Console.WriteLine("1");
                    else
                        Console.WriteLine("0");
                    Console.WriteLine();
                }
            }
        }

        public void InsertVertex(string name)
        {
            vertexList[numberOfVerticesInTheGraph++] = new Vertex(name);
        }

        private int GetIndex(string s)
        {
            for (int i = 0; i < numberOfVerticesInTheGraph; i++)            
                if (s.Equals(vertexList[i].Name))
                    return i;            
            throw new InvalidOperationException("Invalid Vertex");            
        }

        public bool EdgeExists(string s1, string s2)
        {
            return IsAdjacent(GetIndex(s1), GetIndex(s2));
        }

        private bool IsAdjacent(int u, int v)
        {
            return adjacencyMatrix[u, v];
        }

        public void InsertEdge(string s1, string s2)
        {
            int u = GetIndex(s1);
            int v = GetIndex(s2);

            if (u == v)
                throw new InvalidOperationException("Not a valid edge");
            if (adjacencyMatrix[u,v] == true)
                Console.WriteLine("Edge already present");
            else
            {
                adjacencyMatrix[u, v] = true;
                numberOfEdgesInTheGraph++;
            }
        }

        public void DeleteEdge(string s1, string s2)
        {
            throw new NotImplementedException();
        }

        public int OutDegree(string s)
        {
            throw new NotImplementedException();
        }

        public int InDegree(string s1)
        {
            throw new NotImplementedException();
        }
    }
}
