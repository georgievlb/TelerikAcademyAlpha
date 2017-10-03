using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Documentation
{
    class Program
    {    
        public static bool IsPalindrome(string myString)
        {
            string first = myString.Substring(0, myString.Length / 2);
            char[] arr = myString.ToCharArray();
            Array.Reverse(arr);
            string temp = new string(arr);
            string second = temp.Substring(0, temp.Length / 2);
            return first.Equals(second);
        }

        static void Main(string[] args)
        {
            //string input = Console.ReadLine().ToLower();
            //string input = "No x in Nixon";
            //string[] characters = input.Split(' ', ',', '.', '!', '?');
            string[] characters = Console.ReadLine()
                .ToLower()// must change - може if с continue
                .Split(' ', ',', '.', '!', '?');
            StringBuilder builder = new StringBuilder();
            foreach (var item in characters)
            {
                builder.Append(item);
            }
            //Console.WriteLine(builder.ToString());
            string newInput = builder.ToString();
            //Console.WriteLine(newInput);

            if (IsPalindrome(newInput) == true)
            {
                Console.WriteLine(0);
                return;
            }
            int numberOfMinimumOperations = 0;
            //const int MinLetter = 97;
            //const int MaxLetter = 122;
            List<char> newList = new List<char>(newInput);
            int listLenght = newList.Count - 1;
            for (int i = 0; i <= listLenght / 2; i++)
            {
               
                    while (newList[i] <= newList[listLenght])
                    {
                        if (newList[i] == newList[listLenght])
                        {
                            break;
                        }
                        newList[i]++;
                        numberOfMinimumOperations++;
                    }
                    listLenght--;
               
               

            }
            foreach (var letter in newList)
            {
                Console.Write(letter);
            }
            Console.WriteLine();
            //Console.WriteLine((int)('a'));
            //Console.WriteLine((int)('z'));
            //Console.WriteLine((int)('a') - (int)('z'));
            Console.WriteLine(numberOfMinimumOperations);

        }
    }
}