using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackImplementationUsingArray
{
    public class Stack
    {
        private int top;
        private int[] stackArray;

        public Stack()
        {
            top = -1;
            stackArray = new int[10];
        }

        private int Top
        {
            get { return this.top; }
            set { this.top = value; }

        }

        //public int[] StackArray
        //{
        //    get { return this.stackArray; }
        //}

        public void Push(int userInput)
        {
            if (this.Top < -1)
            {
                Console.WriteLine("Stack is empty!");
            }
            else if(this.Top == stackArray.Length - 1)
            {
                Console.WriteLine("Stack is full!");
            }
            else
            {
                Top++;
                stackArray[Top] = userInput;
            }
        }

        public int Pop()
        {
            int poppedElement;
            if (this.Top > stackArray.Length)
            {
                Console.WriteLine("Stack is full!");
                return -1;
            }
            else if (this.Top == -1)
            {
                Console.WriteLine("Stack is empty!");
                return -1;
            }
            else
            {
                poppedElement = stackArray[Top];
                stackArray[Top] = 0;
                Top--;
                Console.WriteLine($"Popped {poppedElement}");
                return poppedElement;
            }
            
        }

        public void Peek()
        {
                if (Top <= -1)
                Console.WriteLine("Stack is empty!");

                else
                Console.WriteLine(stackArray[Top]);
        }

        public void ShowStack()
        {
            for (int i = 0; i < stackArray.Length; i++)
            {
                Console.WriteLine(stackArray[i]);
            }
        }
    }
}
