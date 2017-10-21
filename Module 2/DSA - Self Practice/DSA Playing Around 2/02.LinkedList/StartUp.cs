using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{ 
    class StartUp
    {
        static void Main(string[] args)
        {
            int choice;
            int userInput;
            int k;
            int x;

            SingleLinkedList list = new SingleLinkedList();
            list.CreateList();

            while (true)
            {
                Console.WriteLine("1. Display list.");
                Console.WriteLine("2. Count the number of nodes.");
                Console.WriteLine("3. Search for an element.");
                Console.WriteLine("4. Insert in empty list/insert at the beginning of the list.");
                Console.WriteLine("5. Insert a node at the end of the list.");
                Console.WriteLine("6. Insert node after a specified node.");
                Console.WriteLine("7. Insert a node before a specified node.");
                Console.WriteLine("8. Insert a node at a specified position.");
                Console.WriteLine("9. Delete first node.");
                Console.WriteLine("10. Delete last node.");
                Console.WriteLine("11. Delete any node.");
                Console.WriteLine("12. Reverse the list.");
                Console.WriteLine("13. Bubble sort by exchanging data.");
                Console.WriteLine("14. Bubble sort by exchanging links.");
                Console.WriteLine("15. MergeSort.");
                Console.WriteLine("16. Insert cycle.");
                Console.WriteLine("17. Detect cycle.");
                Console.WriteLine("18. Remove cycle.");
                Console.WriteLine("19. Quit.");

                Console.WriteLine("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                if (choice == 19)
                    break;

                switch (choice)
                {
                    case 1:
                        list.DisplayList();
                        break;
                    case 2:
                        list.CountNodes();
                        break;
                    case 3:
                        Console.WriteLine("Enter the element you are searching for: ");
                        userInput = int.Parse(Console.ReadLine());
                        list.Search(userInput);
                        break;
                    case 4:
                        Console.WriteLine("Enter the element to be inserted: ");
                        userInput = int.Parse(Console.ReadLine());
                        list.InsertInBeginning(userInput);
                        break;
                    case 5:
                        Console.WriteLine("Enter the element to be inserted: ");
                        userInput = int.Parse(Console.ReadLine());
                        list.InsertAtEnd(userInput);
                        break;
                    case 6:
                        Console.WriteLine("Enter the element to be inserted: ");
                        userInput = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the element after which to insert: ");
                        x = int.Parse(Console.ReadLine());
                        list.InsertAfter(userInput, x);
                        break;
                    //case 7:
                    //    Console.WriteLine("Enter the element to be inserted: ");
                    //    userInput = int.Parse(Console.ReadLine());
                    //    Console.WriteLine("Enter the element before which to insert: ");
                    //    x = int.Parse(Console.ReadLine());
                    //    list.InsertBefore(userInput, x);
                    //    break;
                    //case 8:
                    //    Console.WriteLine("Enter the element to be inserted: ");
                    //    userInput = int.Parse(Console.ReadLine());
                    //    Console.WriteLine("Enter the element position at which to insert: ");
                    //    k = int.Parse(Console.ReadLine());
                    //    list.InsertAtPosition(userInput, k);
                    //    break;
                    //case 9:
                    //    list.DeleteFirstNode();
                    //    break;
                    //case 10:
                    //    list.DeleteLastNode();
                    //    break;
                    //case 11:
                    //    Console.WriteLine("Enter the element to be deleted: ");
                    //    userInput = int.Parse(Console.ReadLine());
                    //    list.DeleteNode(userInput);
                    //    break;
                    //case 12:
                    //    list.ReverseList();
                    //    break;
                    //case 13:
                    //    list.BubbleSortExData();
                    //    break;
                    //case 14:
                    //    list.BubbleSortExLinks();
                    //    break;
                    //case 15:
                    //    list.MergeSort();
                    //    break;
                    //case 16;
                    //    Console.WriteLine("Enter the element at which the cycle has to be inserted: ");
                    //    userInput = int.Parse(Console.ReadLine());
                    //    list.InsertCycle(userInput);
                    //    break;
                    //case 17:
                    //    if (list.HasCycle())
                    //        Console.WriteLine("List has a cycle.");
                    //    else
                    //        Console.WriteLine("List does not have a cycle.");
                    //    break;
                    //case 18:
                    //    list.RemoveCycle();
                    //    break;
                    default:
                        Console.WriteLine("Wrong choice.");
                        break;
                }

                Console.WriteLine();
            }
            Console.WriteLine("Exiting.");
        }
    }
}
