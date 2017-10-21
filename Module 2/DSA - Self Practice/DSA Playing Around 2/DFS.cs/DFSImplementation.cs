using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFS.cs
{    
    public class DepthFirstSearch
    {
        private Stack stack;
        private BinaryTreeNode _root;
        public DepthFirstSearch(BinaryTreeNode rootNode)
        {
            _root = rootNode;
            stack = new Stack();
        }
        public bool Search(int data)
        {
            BinaryTreeNode _current;
            stack.Push(_root);
            while (stack.Count != 0)
            {
                _current = stack.Pop();
                if (_current.Data == data)
                {
                    return true;
                }

                else
                {
                    stack.Push(_current.Right);
                    stack.Push(_current.Left);
                }            
            }
            return false;
        }

    }
}
