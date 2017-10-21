using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.StaticStackArrayImplementation
{
    public class CustomStaticStack
    {
        private int[] arr;
        private int top;

        public CustomStaticStack()
        {
            this.arr = new int[10];
            this.top = -1;
        }

        private int[] Arr
        {
            get
            {
                return this.arr;
            }
        }

        public int Top
        {
            get
            {
                return this.top;
            }
            private set
            {
                this.top = value;
            }
        }

        public int Count
        {
            get
            {
                return this.Arr.Length;
            }
        }

        public void Push(int element)
        {
            this.Top++;
            if (Top > Count)
                throw new ArgumentOutOfRangeException("Stack is full!");

            arr[Top] = element;
            Console.WriteLine($"Pushed {element} to the top of the stack.");

        }
        
        public int Pop()
        {
            if (Top == -1)
                throw new ArgumentOutOfRangeException("Stack is empty!");

            int pop = arr[Top];
            arr[Top] = 0;
            Top--;
            Console.WriteLine($"Popped {pop}.");
            return pop;
        }

        public void Peek()
        {
            if (Top == -1)
                throw new ArgumentOutOfRangeException("Stack is empty!");

            Console.WriteLine(arr[Top]);
        }

        public void Clear()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = 0;
            }
            Console.WriteLine("Cleared the stack.");
        }

        public void ShowStack()
        {
            Console.WriteLine("Top of stack:");
            for (int i = arr.Length -1 ; i >= 0; i--)
            {                
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("Reached bottom of stack.");
        }
    }
}
