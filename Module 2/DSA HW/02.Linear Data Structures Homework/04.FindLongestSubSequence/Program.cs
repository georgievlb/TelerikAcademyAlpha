using System;
using System.Collections.Generic;

namespace _06.RemoveOddRepetitionsofN
{
    class Program
    {
        static List<int> FindSubsequence(List<int> sequence)
        {            
            int currentLength = 1;
            int currentNum = sequence[0];
            int bestLength = 1;
            int bestNum = sequence[0];

            for (int i = 1; i < sequence.Count; i++)
            {
                if (sequence[i] == currentNum)
                {
                    currentLength++;
                    if (currentLength > bestLength)
                    {
                        bestLength = currentLength;
                        bestNum = currentNum;
                    }
                }
                else
                {
                    currentNum = sequence[i];
                    currentLength = 1;
                }
            }

            List<int> answers = new List<int>(bestLength);
            for (int inputingCount = 0; inputingCount < bestLength; inputingCount++)
            {
                answers.Add(bestNum);
            }

            return answers;
        }

        static void Main(string[] args)
        {
            List<int> inputList = new List<int>() { 1, 2, 2, 9, 1, 1, 1, 5, 5, 5, 5, 5, 5, 5, 5, 5, 4, 4 , 4, 1, 2, 1, 2, 3, 3, 3, 3, 0 ,1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 2 };
            List<int> outputList = FindSubsequence(inputList);
            Console.Write("Result:");
            foreach (int element in outputList)
            {
                Console.Write("{0,3}", element);
            }
            Console.WriteLine();

           
        }
    }
}
