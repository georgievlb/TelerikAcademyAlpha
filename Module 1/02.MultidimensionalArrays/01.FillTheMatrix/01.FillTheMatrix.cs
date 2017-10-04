using System;

class Program
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        char choice = char.Parse(Console.ReadLine());
        int[,] matrix = new int[size, size];
        int starterValue = 1;

        switch (choice)
        {// switch start
            case 'a':   //case a start

                for (int column = 0; column < size; column++)
                {
                    for (int row = 0; row < size; row++)
                    {
                        matrix[row, column] = starterValue;
                        starterValue++;
                    }
                }
                //print the matrix
                for (int row = 0; row < size; row++)
                {
                    for (int col = 0; col < size; col++)
                    {
                        if (col != size - 1)
                            Console.Write(matrix[row, col] + " ");

                        else
                            Console.Write(matrix[row, col]);

                    }
                    Console.WriteLine();
                }
                break;  // case a end

            case 'b': // case b start

                for (int col = 0; col < size; col++)
                {
                    if (col % 2 == 0)
                    {
                        for (int row = 0; row < size; row++)
                        {
                            matrix[row, col] = starterValue;
                            starterValue++;
                        }
                    }

                    else
                    {
                        for (int row = size - 1; row >= 0; row--)
                        {
                            matrix[row, col] = starterValue;
                            starterValue++;
                        }
                    }
                }

                //print the matrix
                for (int row = 0; row < size; row++)
                {
                    for (int col = 0; col < size; col++)
                    {
                        if (col != size - 1)
                            Console.Write(matrix[row, col] + " ");

                        else
                            Console.Write(matrix[row, col]);

                    }

                    Console.WriteLine();
                }
                break; // case b end

            case 'c':

                for (int row = size - 1; row >= 0; row--)   //обхожда редовете от row 3 до row 0
                {
                    int coll = 0;   //обхожда колоните до средата по диагонал

                    for (int roww = row; roww < size; roww++)   //запазва стойности и обхожда диагоналите до средата
                    {
                        matrix[roww, coll++] = starterValue;
                        starterValue++;
                    }

                }


                int col2 = 0;
                for (int col = 1; col < size; col++)     //трябва да обхожда диагоналите след средата
                {
                    int row2 = 0;
                    col2 = col;
                    while (col2 < size)
                    {
                        matrix[row2, col2] = starterValue;
                        starterValue++;
                        row2++;
                        col2++;
                    }
                }


                //print the matrix
                for (int row = 0; row < size; row++)
                {
                    for (int col = 0; col < size; col++)
                    {
                        if (col != size - 1)
                            Console.Write(matrix[row, col] + " ");

                        else
                            Console.Write(matrix[row, col]);

                    }

                    Console.WriteLine();
                }


                break;

            case 'd':
                break;

        } // switch end              
    }

}
