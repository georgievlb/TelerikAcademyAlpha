using System;

class Program
{
    static void Main()
    {
        string firstString = Console.ReadLine();
        string secondString = Console.ReadLine();

        char[] firstArr = new char[firstString.Length];
        char[] secondArr = new char[secondString.Length];

        for (int i = 0; i < firstArr.Length; i++)
        {
            firstArr[i] = firstString[i];
        }

        for (int i = 0; i < secondArr.Length; i++)
        {
            secondArr[i] = secondString[i];
        }

        int min = Math.Min(firstArr.Length, secondArr.Length);
        int counter = 0;
        do
        {
            if (firstArr[counter] > secondArr[counter])
            {
                Console.WriteLine(">");
                break;
            }
            else if (firstArr[counter] < secondArr[counter])
            {
                Console.WriteLine("<");
                break;
            }
            else if (firstArr[counter] == secondArr[counter])
            {
                if (counter != min)
                {
                    counter++;
                    //Console.WriteLine(counter);
                }
                if (counter == min)
                {
                    if (firstArr.Length == secondArr.Length)
                    {
                        Console.WriteLine("=");
                        break;
                    }
                    else
                    {
                        if (min == firstArr.Length)
                        {
                            Console.WriteLine("<");
                            break;
                        }
                        else
                        {
                            Console.WriteLine(">");
                            break;
                        }
                    }
                }
            }

        }
        while (counter != min);
    }
}

