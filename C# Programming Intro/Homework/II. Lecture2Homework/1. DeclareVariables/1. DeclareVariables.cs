using System;

class DeclareVariables
{
    static void Main()
    {
        ushort  variable1  = 52130;
        sbyte   variable2  = -115;
        uint    variable3  = 4825932;
        byte    variable4  = 97;
        short   variable5  = -10000;
        ushort  variable6  = 20000;
        byte    variable7  = 224;
        uint    variable8  = 970700000;
        byte    variable9  = 112;
        sbyte   variable10 = -44;
        int     variable11 = -1000000;
        ushort  variable12 = 1990;
        ulong   variable13 = 123456789123456789;
        Console.WriteLine(
            "Variable1 has a value of: {0}, its type is ushort and its size is {1} byte(s)", variable1, sizeof(ushort));
        Console.WriteLine(
            "Variable2 has a value of: {0}, its type is sbyte and its size is {1} byte(s)", variable2, sizeof(sbyte));
        //print the type, name, value and size of each variable

        //Console.WriteLine("The size of variable1 is {0}", sizeof(variable1));
    }
}

