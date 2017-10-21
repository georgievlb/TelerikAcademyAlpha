using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    public class Node
    {
        private int dataHeldByNode;         //info
        private Node linkToNextElement;     //link

        public Node(int i)
        {
            this.dataHeldByNode = i;
            this.linkToNextElement = null;
        }

        public int Info
        {
            get { return this.dataHeldByNode; }
            set { dataHeldByNode = value; }
        }

        public Node Link
        {
            get { return this.linkToNextElement; }
            set { linkToNextElement = value; }
        }
    }
}
