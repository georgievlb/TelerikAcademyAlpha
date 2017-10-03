using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arrays = new int[2];
        string[] sizeOfArrays = Console.ReadLine().Split();
        for (int i = 0; i < arrays.Length; i++)
        {
            arrays[i] = int.Parse(sizeOfArrays[i]);
        }

        int[] arr1 = new int[arrays[0]];
        int[] arr2 = new int[arrays[1]];

        string[] elementsOfArray1 = Console.ReadLine().Split();
        for (int i = 0; i < arr1.Length; i++)
        {
            arr1[i] = int.Parse(elementsOfArray1[i]);
        }
        Array.Reverse(arr1);
        Console.WriteLine("the last digit is kept at the zero element, zero element = " + arr1[0]);

        string[] elementsOfArray2 = Console.ReadLine().Split();
        for (int i = 0; i < arr2.Length; i++)
        {
            arr2[i] = int.Parse(elementsOfArray2[i]);
        }
        Array.Reverse(arr2);
        Console.WriteLine("the last digit is kept at the zero element, zero element = " + arr2[0]);

        addArrays(arr1, arr2);
    }

    public static int[] addArrays(int[] arr1, int[] arr2)
    {
        int max = Math.Max(arr1.Length, arr2.Length);
        int[] sum = new int[max];
        for (int i = 0; i <= arr1.Length - 1; i++)
        {
            sum[i] += arr1[i];            
        }

        Array.Reverse(sum);
        //print sum array after the first summing
        for (int i = 0; i < sum.Length; i++)
        {
            Console.Write(sum[i] + " ");
        }
        Console.WriteLine("the last digit is kept at the zero element, zero element = " + sum[0]);

        Array.Reverse(arr2);
        for (int i = 0; i < arr2.Length; i++)
        {
            Console.Write(arr2[i] + " ");
        }

        
        //for (int i = 0; i < arr2.Length; i++)
        //{
        //    sum[i] += arr2[i];
        //}

        ////print sum array after the second summing
        //for (int i = 0; i < sum.Length; i++)
        //{
        //    Console.Write(sum[i] + " ");
        //}

        ////Console.WriteLine("this is a new line after sum array has added the second array");
        return sum;
    }
}
