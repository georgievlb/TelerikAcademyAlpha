using System;

class Program
{
    private static decimal power(int baseOfExponent, int exponent)
    {
            //Console.Write("base = ");
            //string numberAsString = Console.ReadLine();
            //baseOfExponent = int.Parse(numberAsString);
            //Console.Write("exponent = ");
            //numberAsString = Console.ReadLine();
            //exponent = int.Parse(numberAsString);

            decimal result = 1;

            for (int i = 0; i < exponent; i++)
            {
                result *= baseOfExponent;
            }

            //Console.WriteLine("base^exponent = " + result);
        
        return result;
    }


    static void Main(string[] args)
    {
        decimal max = 2048; //A0;
        decimal n = ushort.Parse(Console.ReadLine());
        max -= n;
        decimal divider = 1024;
        int i = 10;
        int p = 9;
       
        while (max > divider || i > 0)
        {
            if (max - divider < 0)
            {
                i--;
            }


            if (divider == 1024)
                {
                    Console.WriteLine("A0");
                }

                else if (divider == 512)
                {
                    Console.WriteLine("A1");
                }

                else if (divider == 256)
                {
                    Console.WriteLine("A2");
                }

                else if (divider == 128)
                {
                    Console.WriteLine("A3");
                }

                else if (divider == 64)
                {
                    Console.WriteLine("A4");
                }

                else if (divider == 32)
                {
                    Console.WriteLine("A5");
                }

                else if (divider == 16)
                {
                    Console.WriteLine("A6");
                }

                else if (divider == 8)
                {
                    Console.WriteLine("A7");
                }

                else if (divider == 4)
                {
                    Console.WriteLine("A8");
                }

                else if (divider == 2)
                {
                    Console.WriteLine("A9");
                }

                //else if (divider == 1)
                //{
                //    Console.WriteLine("A10");
                //}

          
            max -= divider;
            i--;
            divider = power(2, i);
            
         
        }
        
        //Console.WriteLine(power(2, 4));
    }
}

