using System;

class charToASCII
{
    static void Main()
    {
        //for (char a = 'a'; a <= 'z'; a++)
        //{
        //    int b = Convert.ToInt32(a);
        //    Console.WriteLine("The ASCII symbol of {0} is {1}", a, b);
        //}
        char a = 'a';
        while (a <= 'z')
        {
            int b = Convert.ToInt32(a);
            Console.WriteLine("The ASCII symbol of {0} is {1}", a, b);
            a++;
        }
    }
}

