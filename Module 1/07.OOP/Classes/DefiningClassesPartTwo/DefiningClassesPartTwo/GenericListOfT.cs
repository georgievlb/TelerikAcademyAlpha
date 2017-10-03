using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPartTwo
{
    public class GenericList<T>
    {
        private T[] elements;
        private int LastElementIndex;
        private int size;

        //po dobre sloji int v razmera i posle pravi proverki
        public GenericList(int size)            // ne se slaga uint zashtoto default se slaga int
        {
            if( size < 1 )
            {
                throw new ArgumentException("The size must be larger than zero.");
            }
            this.size = size;            
            //this.elements = new T[this.size];
            //LastElementIndex = 0;     //this.clear gi zamestva tiq dva reda
            this.Clear();
        }

        public int Length
        {
            get
            {
                return this.LastElementIndex;
            }
        }

        public T this [int index]
        {
            get
            {
                if( index < 0 || index > this.LastElementIndex - 1)
                {
                    throw new ArgumentOutOfRangeException($"Index must be between zero and {this.LastElementIndex}");
                }

                return this.elements[index];
            }
        }

        public void Add(T element)
        {
            if(LastElementIndex == this.size)
            {
                this.Grow();
            }

            this.elements[LastElementIndex] = element;
            LastElementIndex++;
        }

        public void Insert(T element, int index)
        {
            if (this.LastElementIndex == index)
            {
                this.Add(element);
                return;
            }

            
            if (index < 0 || index > this.LastElementIndex - 1)
            {
                throw new ArgumentOutOfRangeException($"Index must be between zero and {this.LastElementIndex}");
            }

            if (this.LastElementIndex == this.size)
            {
                this.Grow();
            }

            T[] newElements = new T[this.size];
            for (int i = 0; i < index - 1; i++)
            {
                newElements[i] = this.elements[i];
                              
            }

            newElements[index] = element;

            for(int i = index; i < this.LastElementIndex; i++)
            {
                newElements[i + 1] = this.elements[i];
            }
            this.elements = newElements;
            this.LastElementIndex++;


        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index > this.LastElementIndex - 1)
            {
                throw new ArgumentOutOfRangeException($"Index must be between zero and {this.LastElementIndex}");

            }

            if (index < 0 || index > this.LastElementIndex - 1)
            {
                throw new ArgumentOutOfRangeException($"Index must be between zero and {this.LastElementIndex}");
            }

            T[] newElements = new T[this.size];
            for (int i = 0; i < index - 1; i++)
            {
                newElements[i] = this.elements[i];

            }
            

            for (int i = index; i < this.LastElementIndex; i++)
            {
                newElements[i] = this.elements[i + i];
            }
            this.elements = newElements;
            this.LastElementIndex--;
        }

        public void Clear()
        {
            this.elements = new T[this.size];
            this.LastElementIndex = 0;
        }

        public int IndexOf(T element)
        {
            int result = -1;
            for (int i = 0; i < this.LastElementIndex; i++)
            {
                if(this.elements[i].Equals(elements))
                {
                    result = i;
                    break;
                }
            }

            return result;
        }

        public T Min()  // za max e obratnoto
            
        {
            if(this.LastElementIndex == 0)
            {
                return default(T);
            }

            if(this.LastElementIndex == 1)
            {
                return this.elements[0];
            }

            T result = this.elements[0];
            for (int i = 0; i < this.LastElementIndex; i++)
            {
                if (this.elements[i].CompareTo(result) < 0) //sloji IComparable interface // za max e obratnoto > 0
                {
                    result = this.elements[i];
                }
            }
            return result;
        }

        private void Grow()
        {            
            T[] newElements = new T[this.size * 2];
            for (int i = 0; i < this.LastElementIndex; i++)
            {
                newElements[i] = this.elements[i];
            }

            this.elements = newElements;
            //this.size *= 2; tva se pishe kato obedinish 2-te proverki da sa v grow-a
        }
    }
}
