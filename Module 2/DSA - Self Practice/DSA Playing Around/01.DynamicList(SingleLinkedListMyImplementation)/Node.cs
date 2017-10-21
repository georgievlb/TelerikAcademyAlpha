using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DynamicList_SingleLinkedListMyImplementation_
{
    public class Node
    {
        public object Data { get; set; }    // this is the element data
        public Node NextNode { get; set; }

        public Node(object data)
        {
            this.Data = data;
        }

        public Node(object data, Node prevNode)
        {
            this.Data = data;
            prevNode = this;
        }
    }
}
