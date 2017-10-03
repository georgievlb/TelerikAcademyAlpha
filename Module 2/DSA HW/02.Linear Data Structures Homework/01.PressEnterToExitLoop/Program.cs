using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            int x = 0;
            
            //(Console.ReadKey(true).Key == ConsoleKey.Enter)
            while (true)
            {
                //може и с input - Console.ReadLine()
                //íf (input == "") празен стринг
                Console.WriteLine("Enter a positive number or press enter to quit.");
                string input = Console.ReadLine();
                if (!int.TryParse(input, out int result))
                {
                    break;
                }
                else
                {
                    x = int.Parse(input);
                    list.Add(x);                    
                }
               
            }
            Console.WriteLine($"Sum is {list.Sum()}.");
            Console.WriteLine($"Average is {list.Average()}.");
            Console.WriteLine("##############");

            Console.WriteLine("Bye");
        }
    }
}
