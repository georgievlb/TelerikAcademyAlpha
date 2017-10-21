using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        public static int BinarySearch(int[] arr, int minIndex, int maxIndex, int value)
        {
            //първото дъно е ако се разминават мин и макс
            if (minIndex > maxIndex) //индексите
            {
                return -1;
            }
            else
            {
                int midIndex = (minIndex + maxIndex) / 2;
                int midElement = arr[midIndex];
                if (value == midElement) //другото дъно е когато средният елемент е равен на нашия търсен елемент
                {
                    return midIndex;
                }

                else if (value < midElement)
                {
                    return BinarySearch(arr, minIndex, midIndex - 1, value);
                }

                else
                {
                    return BinarySearch(arr, midIndex + 1, maxIndex, value);
                }
                
            }
        }


        static void Main()
        {
            int[] arr = new int[] { 10, 15, 20, 39, 49, 78, 90, 101, 201, 230 };
            
            int searchValue = (BinarySearch(arr, 0, 10, 10));
        }
    }
}
