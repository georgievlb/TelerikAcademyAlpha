using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackImplementationUsingLinkedList
{
    public class Stack
    {
        private Node start;

        public Stack()
        {
            start = null;
        }

        public Node Start
        {
            get { return this.start; }
            //private set { this.start = value; }
        }
       
    }
}
