using System;
using System.Collections.Generic;

namespace Conference
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

        public void Display()//display the adjacency matrix
        {
            for (int row = 0; row < vertices.GetLength(0); row++)
            {
                for (int col = 0; col < vertices.GetLength(1); col++)
                {
                    Console.Write("{0, 3}", vertices[row, col]);
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

        public void BfsAll()
        {
            bool[] visited = new bool[vertices.GetLength(0)];
            int vertex;
            for (vertex = 0; vertex < vertices.GetLength(0); vertex++)
            {
                visited[vertex] = false;

                Console.WriteLine("Enter starting vertex: ");
                int s = int.Parse(Console.ReadLine());
                Bfs(s);

                for (vertex = 0; vertex < vertices.GetLength(0); vertex++)
                {
                    if (visited[vertex] == false)
                        Bfs(vertex);
                }

            }


        }

        public void BFS2(int node)
        {
            bool[] visited = new bool[vertices.GetLength(0)];
            Queue<int> qu = new Queue<int>();
            qu.Enqueue(node);
            visited[node] = true;
            int count = 1;

            while (qu.Count != 0)
            {
                int currentNode = qu.Dequeue();
                count++;
                Console.WriteLine(currentNode);

                for (int i = 0; i < vertices.GetLength(0); i++)
                {
                    if (vertices[currentNode, i] == 1 && !visited[i])
                    {
                        qu.Enqueue(i);
                        visited[i] = true;
                    }
                }
            }
            Console.WriteLine("Number of possible pairs: {0}", count);
        }

        public void FindCommonColleage(int[,] vertices)
        {
            for (int i = 0; i < vertices.GetLength(0); i++)
            {
                for (int j = 0; j < vertices.GetLength(1); j++)
                {
                    if (i == j && vertices[i, j] != 1)
                    {
                        vertices[i,j] = 1;
                    }
                }
            }
        }
    }
}