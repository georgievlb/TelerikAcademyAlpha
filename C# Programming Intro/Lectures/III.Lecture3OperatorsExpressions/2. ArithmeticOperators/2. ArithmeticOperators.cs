using System;

class Program
{
    static void Main()
    {
        int squarePerimeter = 17;
        double squareSide = squarePerimeter / 4.0;
        double squareArea = squareSide * squareSide;
        Console.WriteLine(squareSide);
        Console.WriteLine(squareArea);

        int a = 5;
        int b = 4;
        Console.WriteLine(a + b);   //9
        Console.WriteLine(a + b++); //9
        Console.WriteLine(a + b);   //10
        Console.WriteLine(a+ (++b));//11
        Console.WriteLine(a + b);   //11
        Console.WriteLine(14 / a); //2
        Console.WriteLine(14 % a); //4
        
        int one = 1;
        int zero = 0;
        //Console.WriteLine(one / zero); DivideByZeroException

        double dMinusOne = -1.0;
        double dZero = 0.0;
        Console.WriteLine(dMinusOne / zero);
        Console.WriteLine(one / dZero);
        int z = 5 % 8;
        Console.WriteLine(z);
        int bigNum = 2000000000;
        
        
        //checked
        //{
        //    int bigSum = 2 * bigNum;
        //    Console.WriteLine(bigSum);
        //}
        Console.WriteLine(1.5/0.0);    
        // nestho kato predvaritelna proverka    
        try
        {
            int ba = 0;
            Console.WriteLine(5 / ba);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("nasrahme se");
        }

        //checked
        //{
        //    int bigg = 2000000000;
        //    bigg = bigg * 2;
        //}
    }
}
