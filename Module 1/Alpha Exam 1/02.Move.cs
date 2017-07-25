using System;
using System.Collections.Generic;

class Program
{

    static void Main(string[] args)
    {
        int startPosition = int.Parse(Console.ReadLine());

        string[] elementsOfArray = Console.ReadLine().Split(',');

        int[] arrayForJumps = new int[elementsOfArray.Length];
        for (int i = 0; i < elementsOfArray.Length; i++)
        {
            arrayForJumps[i] = Convert.ToInt16(elementsOfArray[i]);
        }

        List<string> listOfInstructions = new List<string>();

        while (!listOfInstructions.Contains("exit"))
        {

            listOfInstructions.Add(Console.ReadLine());
        }
        listOfInstructions.Remove("exit");
        string[] instructions = listOfInstructions.ToArray();

        int numberOfInstructions = instructions.Length;

        int sumOfForward = 0;
        int sumOfBackward = 0;

        for (int i = 0; i < instructions.Length; i++)
        {
            string[] currentInstructions = new string[3];
            currentInstructions = instructions[i].Split(' ');
            int steps = int.Parse(currentInstructions[0]);
            int size = int.Parse(currentInstructions[2]);
            string direction = currentInstructions[1];

            if (direction == "forward")
            {
                for (int count = 0; count < steps; count++)
                {
                    if (startPosition + size >= arrayForJumps.Length)
                    {
                        startPosition = (startPosition + size) % arrayForJumps.Length;
                        sumOfForward += arrayForJumps[startPosition];
                    }

                    else
                    {
                        startPosition += size;
                        sumOfForward += arrayForJumps[startPosition];
                    }
                }
            }

            else     //direction = "backwards"
            {
                for (int count = 0; count < steps; count++)
                {
                    if (startPosition + size > 0)
                    {
                        int newStartPosition = arrayForJumps.Length - startPosition - 1;
                        newStartPosition = (newStartPosition + size) % arrayForJumps.Length;
                        startPosition = arrayForJumps.Length - newStartPosition - 1;
                        sumOfBackward += arrayForJumps[startPosition];
                    }
                }
            }

        }
        Console.WriteLine("Forward: {0}", sumOfForward);
        Console.WriteLine("Backwards: {0}", sumOfBackward);
    }

}

