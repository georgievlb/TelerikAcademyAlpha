using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.LinkedListImplementation
{
    public class SingleLinkedList
    {
        private class Node
        {
            private int element;
            private Node link;

            public Node(int element)
            {
                this.Element = element;
            }

            public Node(int element, Node prevNode)
            {
                this.Element = element;
                prevNode.link = this;
            }

            public int Element
            {
                get { return element; }
                set { this.element = value; }
            }

            public Node Link
            {
                get { return this.link; }
                set { link = value; }
            }
        }
        private Node head;
        private Node tail;
        private int count;

        public SingleLinkedList()
        {
            this.head = null;
            this.tail = null;
            this.count = 0;
        }

        public int Count
        {
            get { return this.count; }
        }

        public void Add(int item)
        {
            if (this.head == null)
            {
                head = new Node(item);
                tail = head;
            }
            else
            {
                Node newNode = new Node(item, tail);
                tail = newNode;
            }
            count++;
            Console.WriteLine($"Added {item} to the list.");
        }

        public void DisplayList()
        {
            while(head != null)
            {
                Console.WriteLine(head.Element);
                head = head.Link;
            }
        }


    }
}
