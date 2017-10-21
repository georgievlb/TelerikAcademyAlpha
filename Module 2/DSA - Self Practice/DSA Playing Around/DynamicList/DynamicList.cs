using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicList
{
    public class DynamicList
    {
        private class Node//Както виждаме класът е вътрешен за класа DynamicList (деклариран е в тялото на класа и е private) 
            //и следователно може да се достъпва само от него.
        {
            private object element;
            private Node next;
                        
            public Node(object element)
            {
                this.Element = element;
                next = null;
            }
            
            public Node(object element, Node prevNode)
            {
                this.Element = element;
                prevNode.next = this;
            }
            public object Element
            {
                get { return this.element; }
                set { this.element = value; }
            }

            public Node Next
            {
                get { return this.next; }
                set { this.next = value; }
            }            
        }//end of Node class

        private Node head;
        private Node tail;
        private int count;

        public DynamicList()
        {
            this.head = null;
            this.tail = null;
            this.count = 0;
        }

        public void Add(object item) // Add element at the end of the list
        {
            //item: the element you wish to add
            if (head == null)
            {
                // We have empty list
                head = new Node(item);
                tail = head;
            }
            else
            {
                // We have non-empty list
                Node newNode = new Node(item, tail);
                tail = newNode;
            }
            count++;
        }

        public object Remove(int index)// Removes and returns element on the specific index
        {
            //index: The index of the element you want to remove
            if (index >= count || index < 0)
            {
                throw new ArgumentOutOfRangeException(
                "Invalid index: " + index);
            }

            // Find the element at the specified index
            int currentIndex = 0;
            Node currentNode = head;
            Node prevNode = null;
            while (currentIndex < index)
            {
                prevNode = currentNode;
                currentNode = currentNode.Next;
                currentIndex++;
            }

            // Remove the element
            count--;
            if (count == 0)
            {
                head = null;
            }
            else if (prevNode == null)
            {
                head = currentNode.Next;
            }
            else
            {
                prevNode.Next = currentNode.Next;
            }

            // Find last element
            Node lastElement = null;
            if (this.head != null)
            {
                lastElement = this.head;
                while (lastElement.Next != null)
                {
                    lastElement = lastElement.Next;
                }
            }
            tail = lastElement;

            return currentNode.Element; //return: The removed element
        }

        public int Remove(object item)// Removes the specified item and return its index
        {
            //item: The item you are searching for
            // Find the element containing searched item
            int currentIndex = 0;
            Node currentNode = head;
            Node prevNode = null;
            while (currentNode != null)
            {
                if ((currentNode.Element != null &&
                currentNode.Element.Equals(item)) ||
                (currentNode.Element == null) && (item == null))
                {
                    break;
                }
                prevNode = currentNode;
                currentNode = currentNode.Next;
                currentIndex++;
            }

            if (currentNode != null)
            {
                // Element is found in the list. Remove it
                count--;
                if (count == 0)
                {
                    head = null;
                }
                else if (prevNode == null)
                {
                    head = currentNode.Next;
                }
                else
                {
                    prevNode.Next = currentNode.Next;
                }

                // Find last element
                Node lastElement = null;
                if (this.head != null)
                {
                    lastElement = this.head;
                    while (lastElement.Next != null)
                    {
                        lastElement = lastElement.Next;
                    }
                }
                tail = lastElement;

                return currentIndex;
            }
            else
            {
                // Element is not found in the list
                return -1;//return: the index of the first occurrence of the element in the list or -1 when not found
            }
        }

        public int IndexOf(object item)// Searches for given element in the list
        {
            //item: The item you are searching for
            int index = 0;
            Node current = head;
            while (current != null)
            {
                if ((current.Element != null &&
                current.Element == item) ||
                (current.Element == null) && (item == null))
                {
                    return index;
                }
                current = current.Next;
                index++;
            }
            return -1;//return: the index of the first occurrence of the element in the list or -1 when not found
        }

        public bool Contains(object item)// Check if the specified element exists in the list
        {
            //item: The item you are searching for
            int index = IndexOf(item);
            bool found = (index != -1);
            return found;//return: True if the element exists or false otherwise
        }

        public object this[int index]// Gets or sets the element on the specified position
        {
            //index: The position of the element [0 … count-1]
            get
            {
                if (index >= count || index < 0)
                {
                    throw new ArgumentOutOfRangeException(
                    "Invalid index: " + index);
                }
                Node currentNode = this.head;
                for (int i = 0; i < index; i++)
                {
                    currentNode = currentNode.Next;
                }
                return currentNode.Element;//return: The object at the specified index
            }
            set
            {
                if (index >= count || index < 0)
                {
                    throw new ArgumentOutOfRangeException(
                    "Invalid index: " + index);
                }
                Node currentNode = this.head;
                for (int i = 0; i < index; i++)
                {
                    currentNode = currentNode.Next;
                }
                currentNode.Element = value;

            }
        }

        public int Count// Gets the number of elements in the list
        {
            get
            {
                return count;
            }
        }
    }
}
