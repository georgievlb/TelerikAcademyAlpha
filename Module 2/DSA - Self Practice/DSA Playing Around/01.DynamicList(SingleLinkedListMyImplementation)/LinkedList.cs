using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DynamicList_SingleLinkedListMyImplementation_
{
    public class LinkedList
    {
        private Node head;
        private Node tail;
        private int count; 

        public LinkedList()
        {
            this.head = null;
            this.tail = null;
            this.count = 0;
        }

        public int Count
        {
            get { return this.count; }
        }

        public void InsertAtBeginning()
        {

        }



    }
}
