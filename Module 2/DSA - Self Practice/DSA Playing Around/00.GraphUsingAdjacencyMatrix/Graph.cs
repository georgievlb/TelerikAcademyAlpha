using System;
using System.Collections.Generic;

namespace GraphUsingAdjacencyMatrix
{

    public class Graph
    {
        private int[,] vertices;

        public Graph(int[,] vertices)
        {
            this.vertices = vertices;
        }

        public void AddEdge(int i, int j)
        {
            vertices[i, j] = 1;
        }

        public void RemoveEdge(int i, int j)
        {
            vertices[i, j] = 0;
        }

        public bool HasEdge(int i, int j)
        {
            return vertices[i, j] == 1;
        }

        public IList<int> GetSuccessors(int i)
        {
            IList<int> successors = new List<int>();

            for (int j = 0; j < vertices.GetLength(1); j++)
            {
                if (vertices[i, j] == 1)
                {
                    successors.Add(j);
                }
            }

            return successors;
        }

        public void Display(int[,] adjacencyMatrix)//display the adjacency matrix
        {
            for (int row = 0; row < adjacencyMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < adjacencyMatrix.GetLength(1); col++)
                {
                    Console.Write("{0, 3}", adjacencyMatrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        public void Bfs(int node)
        {
            bool[] visited = new bool[vertices.GetLength(0)];
            var nodes = new Queue<int>();
            nodes.Enqueue(node);
            visited[node] = true;
            while (nodes.Count != 0)
            {
                int currentNode = nodes.Dequeue();
                Console.WriteLine(currentNode);

                for (int i = 0; i < vertices.GetLength(0); i++)
                {
                    if (vertices[currentNode, i] == 1 && !visited[i])
                    {
                        nodes.Enqueue(i);
                        visited[i] = true;
                    }
                }
            }
        }

        public void Dfs(int node)
        {
            bool[] visited = new bool[vertices.GetLength(0)];
            var nodes = new Stack<int>();
            nodes.Push(node);
            visited[node] = true;
            while (nodes.Count != 0)
            {
                int currentNode = nodes.Pop();
                Console.WriteLine(currentNode);

                for (int i = 0; i < vertices.GetLength(0); i++)
                {
                    if (vertices[currentNode, i] == 1 && !visited[i])
                    {
                        nodes.Push(i);
                        visited[i] = true;
                    }
                }
            }
        }

        public void DfsRecursive(int node)
        {
            bool[] visited = new bool[vertices.GetLength(0)];
            Console.WriteLine(node);
            visited[node] = true;
          
                for (int i = 0; i < vertices.GetLength(0); i++)
                {
                    if (!visited[i])
                    {
                        DfsRecursive(node);
                    }
                }
        }


        public void BFSMyImplementation(int node)
        {
            bool[] visited = new bool[vertices.GetLength(0)];
            Queue<int> qu = new Queue<int>();
            qu.Enqueue(node);            
            visited[node] = true;
            int count = 1;
            
            while(qu.Count != 0)
            {
                int currentNode = qu.Dequeue();
                count++;
                Console.WriteLine(currentNode);

                for (int i = 0; i < vertices.GetLength(0); i++)
                {
                    if(vertices[currentNode,i] == 1 && !visited[i])
                    {
                        qu.Enqueue(i);
                        visited[i] = true;
                    }
                }
            }
            Console.WriteLine("Number of possible pairs: {0}", count);
        }


    }
}