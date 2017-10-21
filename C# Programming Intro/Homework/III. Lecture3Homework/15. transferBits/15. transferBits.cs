using System;

class bitSwapper
{
    private static int bitSwap(int p1, int p2, int n)
    {
        //originally tested with n values: 11001(25) and //10011(19)
        int mask1 = 1;              //00001     //00001
        int nAndMask1 = 0;
        int mask2 = 1;
        mask1 = mask1 << p1;        //00010     //00010
        mask1 = n & mask1;          //00000     //00010
        mask1 = mask1 >> p1;         //00000     //00001    
        if (mask1 <= 0)
        {
            mask1 = 1;              //00001     

            mask1 = mask1 << p2;         //01000     
            mask1 = ~mask1;             //10111     
            nAndMask1 = n & mask1;      //10001(17 - polucheno kato n = 25)    
            //Console.WriteLine(nAndMask1);
        }
        else
        {
            mask1 = mask1 << p2;         //01000
            nAndMask1 = n | mask1;      //11011(27 - polucheno kato n = 19)
            //Console.WriteLine(nAndMask1); //
        }

        mask2 = mask2 << p2;
        mask2 = n & mask2;
        mask2 = mask2 >> p2;
        if (mask2 <= 0)
        {
            mask2 = 1;
            mask2 = mask2 << p1;
            mask2 = ~mask2;
            nAndMask1 = nAndMask1 & mask2;
            //Console.WriteLine(nAndMask1); //25 pri n = 19
        }
        else
        {
            mask2 = mask2 << p1;
            nAndMask1 = nAndMask1 | mask2;
            //Console.WriteLine(nAndMask1); // 19, pri n = 25
        }

        n = nAndMask1;


        return n;
    }
    static void Main()
    {
        Console.WriteLine("Enter a number whose bits you'd like to swap: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("What is the position of the first bit :");
        int p1 = int.Parse(Console.ReadLine());
        Console.WriteLine("What is the position of the second bit :");
        int p2 = int.Parse(Console.ReadLine());
        Console.WriteLine("What is the position of the next bit: ");
        int pp1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Which position should it go to: ");
        int pp2 = int.Parse(Console.ReadLine());
        Console.WriteLine("What is the position of the next bit: ");
        int ppp1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Which position should it go to: ");
        int ppp2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Swapping bits...");

        n = bitSwap(p1, p2, n);
        n = bitSwap(pp1, pp2, n);
        n = bitSwap(ppp1, ppp2, n);
        Console.WriteLine("Your new number is: {0}", n);
    }
}
