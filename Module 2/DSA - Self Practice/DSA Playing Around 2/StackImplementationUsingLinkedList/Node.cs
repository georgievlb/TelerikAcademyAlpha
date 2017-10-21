using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackImplementationUsingLinkedList
{
    public class Node
    {
        private int data;    //data held by Node
        private Node link;   //link to next element

        public Node(int info)
        {
            this.data = info;
            this.Link = null;
        }
        
        public int Data
        {
            get { return this.data; }
            set { this.data = value; }
        }

        public Node Link
        {
            get { return this.link; }
            set { this.link = value; }
        }
    }
}
