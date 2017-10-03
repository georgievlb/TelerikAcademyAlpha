using System;
using System.Numerics;

namespace HelpDoge
{
    class Program
    {
        //static int F(bool[,] matrix, int dogeX, int dogeY, int foodX, int foodY)
        //{
        //    if (dogeX == foodX && dogeY == foodY)
        //    {
        //        return 1;
        //    }

        //    //if(dogeX > foodX || dogeY > foodY)
        //    //{
        //    //    return 0;
        //    //}

        //    if (dogeX == matrix.GetLength(0) 
        //        ||dogeY == matrix.GetLength(1)
        //        ||matrix[dogeX, dogeY]) //true means enemy
        //    {
        //        return 0;   //ако излезем от матрицата
        //    }

        //    return F(matrix, dogeX + 1, dogeY, foodX, foodY)
        //        + F(matrix, dogeX, dogeY + 1, foodX, foodY);
        //}

        static void Main(string[] args)
        {
            string[] nm = Console.ReadLine().Split(' ');
            int n = int.Parse(nm[0]);
            int m = int.Parse(nm[1]);

            nm = Console.ReadLine().Split(' ');
            int fx = int.Parse(nm[0]);
            int fy = int.Parse(nm[1]);

            int k = int.Parse(Console.ReadLine());

            bool[,] matrix = new bool[n, m];

            for (int i = 0; i < k; i++)
            {
                nm = Console.ReadLine().Split(' ');
                int x = int.Parse(nm[0]);
                int y = int.Parse(nm[1]);

                if(x <= fx && y <= fy)
                {
                    matrix[x, y] = true;
                }
                matrix[x, y] = true;
            }

            BigInteger [,] count = new BigInteger [fx + 1, fy + 1];
            count[0, 0] = 1;
            for (int j = 0; j < count.GetLength(1); j++)
            {
                if(matrix[0,j]) //enemy
                {
                    count[0, j] = 0;
                }
                else
                {
                    count[0, j] = count[0, j - 1];
                }
            }

            for (int i = 0; i < count.GetLength(0); i++)
            {
                if (matrix[0, i]) //enemy
                {
                    count[0, i] = 0;
                }
                else
                {
                    count[0, i] = count[0, i - 1];
                }
            }

            for (int i = 0; i < count.GetLength(0); i++)
            {
                for (int j = 0; j < count.GetLength(1); j++)
                {
                    count[i, j] = matrix[i, j] ? 0 : count[i - 1, j] + count[i, j - 1];
                }
            }

            Console.WriteLine(count[fx, fy]);

            //Console.WriteLine(F(matrix, 0, 0, fx, fy));
        }
    }
}
