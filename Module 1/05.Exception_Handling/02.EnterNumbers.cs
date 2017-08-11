using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] arrA = { 5, 11, 20, 27, 49, 41, 52, 81, 89, 99};
            
        isValidSequence(arrA);
        //try
        //{
        //    int[] arrA = new int[10];

        //    for (int j = 0; j < arrA.Length; j++)
        //    {
        //        arrA[j] = int.Parse(Console.ReadLine());
        //    }
        //    arrA = ReadNumber(1, 100, arrA);

        //    int i = 0;
        //    bool valid = true;
        //    for (i = 0; i < arrA.Length - 2; i++)
        //    {
        //        bool isValidSequence = ((arrA[i] < arrA[i + 1]) && (arrA[0] > 1) && (arrA[arrA.Length - 1] < 100));

        //        if (isValidSequence)
        //        {
        //            valid = true;
        //        }

        //        else
        //        {
        //            valid = false;
        //        }

        //    }

        //    if (valid == true)
        //    {
        //        Console.Write("1 < {0} < {1} < {2} < {3} < {4} < {5} < {6} < {7} < {8} < {9} < 100",
        //        arrA[0], arrA[1], arrA[2], arrA[3], arrA[4], arrA[5], arrA[6], arrA[7], arrA[8],
        //        arrA[9]);
        //    }

        //    else
        //    {
        //        throw new Exception();
        //    }
        //}
        //catch (ArgumentOutOfRangeException)
        //{
        //    Console.WriteLine("Exception");
        //}
        //catch (FormatException)
        //{
        //    Console.WriteLine("Exception");
        //}
        //catch (Exception)
        //{
        //    Console.WriteLine("Exception");
        //}

    }

    public static int[] ReadNumber(int start, int end, int[] numbers)
    {
        try
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (Enumerable.Range(start, end).Contains(numbers[i]))
                {
                    //return numbers[i];
                }

                else
                {
                    throw new ArgumentOutOfRangeException();
                    throw new FormatException();
                }
            }

        }

        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Exception");
        }

        catch (FormatException)
        {
            Console.WriteLine("Exception");
        }

        return numbers;
    }

    public static bool isValidSequence(int[] arrA)
    {
        //for (int i = 0; i < arrA.Length - 2; i++)
        //{   
        //    if ((arrA[i] < arrA[i + 1]) && (arrA[0] > 1) && (arrA[arrA.Length - 1] < 100))
        //        return true;      
        //}
        //return false;
        int i = 0;
        do
        {
            if ((arrA[i] < arrA[i + 1]) && (arrA[0] > 1) && (arrA[arrA.Length - 1] < 100))
                i++;
        } while (i < arrA.Length - 1);

        if (i == 9)
            return true;

        return false;
    }

}

//true 
//if (number >= start && number <= end)
//{
//    //do stuff
//}