using System;

    class Program
    {
        static void Main()
        {
        int[] array = { 1, 2, 3, 4, 5 };
        // Get array size
        int length = array.Length;
        // Declare and create the reversed array
        int[] reversed = new int[length];

        // Initialize the reversed array
        for (int index = 0; index < length; index++)
        {
            reversed[length - index - 1] = array[index];
        }

        // Print the reversed array
        for (int index = 0; index < length; index++)
        {
            Console.Write(reversed[index] + " ");
        }

    }
}


//alternative solution:
//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] testArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//        //testArray[2] = 0;
//        //testArray[4] = 0;

//        Console.Write("The elements of the first array are: \t");
//        for (int index = 0; index < testArray.Length; index++)
//        {

//            Console.Write(testArray[index]);
//        }


//        int length = testArray.Length;
//        Console.WriteLine();
//        Console.WriteLine("The length of the arrays is: \t \t" + length);
//        int[] reverseArray = new int[length];

//        for (int i = 0; i < length; i++)
//        {
//            reverseArray[length - i - 1] = testArray[i];
//        }

//        Console.Write("Here are the elements reversed: \t");
//        for (int i = 0; i < reverseArray.Length; i++)
//        {
//            Console.Write(reverseArray[i]);
//        }

//        Console.WriteLine();
//    }
//}


