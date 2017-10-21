using System;

class BitwiseOperators
{
    static void Main()
    {
        byte a = 3;                 // 0000 0011 = 3
        byte b = 5;                 // 0000 0101 = 5
        
        Console.WriteLine(a | b);   // 0000 0111 = 7
        Console.WriteLine(a & b);   // 0000 0001 = 1
        Console.WriteLine(a ^ b);   // 0000 0110 = 6
        // ~ (tilda) - обръща битовете
        Console.WriteLine(~a & b);  // 0000 0100 = 4
        Console.WriteLine(a << 1);  // 0000 0110 = 6
        Console.WriteLine(a << 2);  // 0000 1100 = 12
        Console.WriteLine(a >> 1);  // 0000 0001 = 1 
        // 32 pozicii ima v long, moje da mestish 31 pozicii
        // 64 pozicii ima v long, moje da mestish 63 pozicii
        int mask = 1;
        mask = mask << 5;
        Console.WriteLine(mask);
        Console.WriteLine(mask << 5);
        //tova pechati chislo v dvoichna sistema shtoto pishe 2, ako pishesh 16 shte e v 16-na
        Console.WriteLine(Convert.ToString(b, 2).PadLeft(32, '0'));
    }
}

