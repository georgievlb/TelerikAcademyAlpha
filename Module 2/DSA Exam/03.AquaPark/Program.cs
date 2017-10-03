using System;
using System.Linq;
using Wintellect.PowerCollections;

namespace _03.AquaPark
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            Deque<int> qu = new Deque<int>();
            string[] commandLine = null;
            while (numberOfCommands > 0)
            {
                commandLine = Console.ReadLine().Split();
                switch (commandLine[0])
                {
                    case "add":
                        int id = int.Parse(commandLine[1]);
                        qu.Add(id);
                        Console.WriteLine("Added {0}", id);

                        break;
                    case "print":
                        Console.WriteLine(string.Join(" ", qu.Reverse()));

                        break; 
                    case "slide":
                        int k = int.Parse(commandLine[1]);
                        int km = int.Parse(commandLine[1]) % qu.Count;
                        Console.WriteLine("Slided {0}", k);

                        for (int i = 0; i < km; i++)
                        {
                            qu.Add(qu.First());
                            qu.RemoveFromFront();
                        }
                        break;
                    default:
                        break;
                };
                numberOfCommands--;
            }
        }
    }
}