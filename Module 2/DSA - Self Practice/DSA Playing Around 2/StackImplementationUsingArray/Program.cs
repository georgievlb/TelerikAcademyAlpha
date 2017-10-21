using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackImplementationUsingArray
{
    class Program
    {
        public static void ShowMenu()
        {
            Console.WriteLine("Choose an option:");

            Console.WriteLine("1. Push");
            Console.WriteLine("2. Pop");
            Console.WriteLine("3. Peek");
            Console.WriteLine("4. Display stack");
            Console.WriteLine("5. Show menu");
            Console.WriteLine("6. Exit");
        }

        static void Main(string[] args)
        {
            Stack stack = new Stack();
            int userInput;
            while(true)
            {
                ShowMenu();
                int choice = int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        Console.Write("Enter value: ");
                        userInput = int.Parse(Console.ReadLine());
                        stack.Push(userInput);
                        break;
                    case 2:
                        stack.Pop();
                        break;
                    case 3:
                        stack.Peek();
                        break;
                    case 4:
                        stack.ShowStack();
                        break;
                    case 5:
                        ShowMenu();
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Wrong choice:");
                        ShowMenu();
                        break;

                }
            }
            
        }
    }
}
