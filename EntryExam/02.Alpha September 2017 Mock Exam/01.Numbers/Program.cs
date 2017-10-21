using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split(' ');
            string number = null;
            while (command[0] != "end")
            {
                
                switch (command[0])
                {
                    
                    case "set":
                        number = command[1];
                        break;
                    case "front-add":
                        break;
                    case "print":
                        if (number == null)
                        {
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine(number);
                        }
                        break;
                    default:
                        break;
                }
                command = Console.ReadLine().Split(' ');

            }
            
        }
    }
}
