using System;

class BitwiseExercise2
{
    
  
    static void Main()
    {
        Console.WriteLine("Enter an integer: ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter bit position to check");
        int pos = int.Parse(Console.ReadLine());
        int mask = 1;
        mask = mask << pos;
        mask = num & mask;
        mask = mask >> pos;
        //bool oneOrZero = 
      

        Console.WriteLine(mask);
    }
}

