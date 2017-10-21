using System;

class NodEvklid
{
    private static void nod(int number1, int number2)
    {
         for (int i = number1; i > 0; i--)
        {
            if (number1 % i == 0 && number2 % i == 0)
            {
                Console.WriteLine("The biggest divider is: {0}", i);
                return;

            }
        }
    }

    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

      if (a > b)
        {
            nod(b, a);
        }
      else // a < b
        {
            nod(a, b);
        }
    }
}


            //for (int i = b; i > 0; i--)
            //{
            //    if (b % i == 0 && a % i == 0)
            //    {
            //        Console.WriteLine("The biggest divider is: {0}", i);
            //        return;
            //    }

            //}