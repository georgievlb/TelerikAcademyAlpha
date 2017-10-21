using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    public class SingleLinkedList
    {
        private Node start;

        public SingleLinkedList()
        {
            start = null;
        }

        public Node Start                     //not sure if I need a property
        {
            get { return this.start; }
            //set { this.start = value; }
        }

        public void DisplayList()
        {
            Node pointer;
            if (start == null)
            {
                Console.Write("List is empty.");
                return;
            }
            Console.Write("List is : ");
            pointer = start;

            while (pointer != null)
            {
                Console.Write(pointer.Info + " ");
                pointer = pointer.Link;
            }
            Console.WriteLine();
        }

        public void CountNodes()
        {
            int numberOfNodes = 0;
            Node pointer = start;
            while (pointer != null)
            {
                numberOfNodes++;
                pointer = pointer.Link;
            }
            Console.WriteLine("Number of nodes in the list = " + numberOfNodes);
        }

        public bool Search(int valueForSearch)
        {
            int position = 1;
            Node pointer = start;
            while (pointer != null)
            {
                if (pointer.Info == valueForSearch)
                    break;
                position++;
                pointer = pointer.Link;
            }

            if (pointer == null)
            {
                Console.WriteLine(valueForSearch + " not found in list");
                return false;
            }
            else
            {
                Console.WriteLine(valueForSearch + $" is at position {position}");
                return true;
            }
        }

        public void InsertInBeginning(int userInput)
        {
            Node temp = new Node(userInput);
            temp.Link = Start;
            start = temp;
        }

        public void InsertAtEnd(int userInput)
        {
            Node pointer;
            Node temp = new Node(userInput);

            if (start == null)
            {
                start = temp;
                return;
            }

            pointer = start;
            while(pointer.Link != null)
            {
                pointer = pointer.Link;
            }

            pointer.Link = temp;
        }

        public void CreateList()
        {
            int userInput = 0;

            Console.Write("Enter the number of nodes: ");
            int numberOfNodes = int.Parse(Console.ReadLine());

            if (numberOfNodes == 0)
                return;

            for (int i = 0; i < numberOfNodes; i++)
            {
                Console.Write("Enter the element to be inserted: ");
                userInput = int.Parse(Console.ReadLine());
                InsertAtEnd(userInput);
            }
        }

        public void InsertAfter(int userInput, int x)
        {
            Node p = start;
            while(p != null)
            {
                if (p.Info == x)
                    break;
                p = p.Link;
            }

            if (p == null)
                Console.WriteLine(x + " not present in the list");
            else
            {
                Node temp = new Node(userInput);
                temp.Link = p.Link;
                p.Link = temp;
            }
        }

        public void InsertBefore(int userInput, int x)
        {
            Node temp;

            // If List is empty
            if (start == null)
            {
                Console.WriteLine("List is empty.");
                return;
            }

            //x is in first node, new node is to be inserted before first node
            if (x == start.Info)
            {
                temp = new Node(userInput);
                temp.Link = start;
                start = temp;
                return;
            }

            // Find reference to predecessor of node containing x
            Node p = start;
            while(p.Link != null)
            {
                if (p.Link.Info == x)
                    break;
                p = p.Link;
            }

            if (p.Link == null)
                Console.WriteLine(x + " not present in the list.");
            else
            {
                temp = new Node(userInput);
                temp.Link = p.Link;
                p.Link = temp;
            }
        }

        public void InsertAtPosition(int userInput, int k)
        {
            Node temp;
            int i;
            if (k == 1)
            {
                temp = new Node(userInput);
                temp.Link = start;
                start = temp;
                return;
            }

            Node p = start;
            for (i = 0; i < k - 1 && p != null; i++) //find a refernce to k-1 node
            {
                p = p.Link;
            }

            if (p == null)
            {
                Console.WriteLine($"You can insert only up to {i}th position");
            }
            else
            {
                temp = new Node(userInput);
                temp.Link = p.Link;
                p.Link = temp;
            }
        }        
    }
}
