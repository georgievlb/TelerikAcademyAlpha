using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticList
{
    public class CustomListImplementedWithArray
    {
        private object[] arr;
        private int count;      //actual list length (how many elements are in the array-based list)
        private static readonly int initialCapacity = 4;

        public CustomListImplementedWithArray()    //this CTOR initializes the array-based list (it allocates memory)
        {
            this.arr = new object[initialCapacity];
            count = 0;
        }

        public int Count
        {
            get { return this.count; }
        }

        public void Add(object item)   //add an element to the list
        {
            Insert(count, item);
        }

        public void Insert(int index, object item)  
            //index: inserts the specified element at a given position in this list
            //item: element to be inserted
        {
           if (index > count || index < 0)
            {
                throw new IndexOutOfRangeException($"Invalid index: {index}");
            }
            object[] extendedArr = arr;
            if (count + 1 == arr.Length)
            {
                extendedArr = new object[arr.Length * 2];
            }
            Array.Copy(arr, extendedArr, index);
            count++;
            Array.Copy(arr, index, extendedArr, index + 1, count - index - 1);
            extendedArr[index] = item;
            arr = extendedArr;
        }

        public int IndexOf(object item) //item: The element you are searching
        //Returns the index of the first occurrence of the specified element in this list.
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (item == arr[i])
                {
                    return i;
                }
            }
            return -1; //return: The index of given element or -1 is not found
        }

        public void Clear()     //clears the list
        {
            arr = new object[initialCapacity];
            count = 0;
        }

        public bool Contains(object item) //check if an element exists
        {
            //item: the element you are searching for
            int index = IndexOf(item);
            bool found = (index != -1);
            return found;//return: shows if the element exists 
        }

        public object this[int index]//Retrieves the element on the set index
        {//index: Index of the element
            get
            {
                if (index >= count || index < 0)
                {
                    throw new ArgumentOutOfRangeException($"Invalid index: {index}");
                }
                return arr[index];//return: The element on the current position
            }
            set
            {
                if (index >= count || index < 0)
                {
                    throw new ArgumentOutOfRangeException($"Invalid index: {index}");
                }
                this.arr[index] = value;
            }
        }

        public object Remove(int index)//Removes the element at the specified index
        {
            //index: The index, whose element you want to remove
            if (index >= count || index < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid index: " + index);
            }
            object item = arr[index];
            Array.Copy(arr, index + 1, arr, index, count - index + 1);
            arr[count - 1] = null;
            count--;

            return item;//return: The removed element
        }

        public int Remove(object item)//Removes the specified item
        {
            int index = IndexOf(item);//item: The item you want to remove
            if (index == -1)
            {
                return index;
            }

            Array.Copy(arr, index + 1, arr, index, count - index + 1);
            count--;

            return index; //return: Item index or -1 if item does not exists
        }


    }
}
