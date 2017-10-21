using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace _05.Medians
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderedBag<int> sequence = new OrderedBag<int>();
            StringBuilder builder = new StringBuilder();
            string line = Console.ReadLine();
            while (line != "EXIT")
            {
                
                string[] line2 = line.Split();
                switch (line2[0])
                {
                    case "ADD":
                        sequence.Add(int.Parse(line2[1]));
                        //Console.WriteLine(sequence.Count);
                        break;
                    case "FIND":
                        //sequence.Sort();
                        if (sequence.Count % 2 == 0)
                        {
                            //Console.WriteLine($"The count of the sequence is {sequence.Count}, so the sequence is even.");
                            int middle = (sequence.Count) / 2; 
                            decimal number1 = sequence[middle - 1]; //left middle element
                            decimal number2 = sequence[middle]; //right middle element
                            decimal median = (number1 + number2) / 2;
                            //Console.WriteLine("The left middle element is {0}", number1);
                            //Console.WriteLine("The right middle element is {0}", number2);
                            //Console.WriteLine("The median is {0}", median);
                            builder.AppendLine(string.Format("{0}", median));
                        }
                        else if(sequence.Count % 2 != 0)
                        {
                            //Console.WriteLine($"The count of the sequence is {sequence.Count}, so the sequence is odd.");
                            int medianIndex = sequence.Count / 2;
                            //Console.WriteLine(medianIndex);
                            //decimal medianValue = sequence[medianIndex];
                            //Console.WriteLine("The median is {0}", medianValue);
                            builder.AppendLine(string.Format("{0}", sequence[medianIndex]));
                        }
                        //foreach (var element in sequence)
                        //{
                        //    builder.Append(string.Format(element + " "));
                        //}
                        break;

                    default:
                        break;
                };
                line  = Console.ReadLine();
            }
            Console.Write(builder.ToString());
            
        }
    }
}
