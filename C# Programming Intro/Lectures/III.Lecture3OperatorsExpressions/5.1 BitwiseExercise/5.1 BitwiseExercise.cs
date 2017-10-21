using System;

class Program
{
    static void Main()
    {
        //taka se otpechatva v nqkakva broina sistema, ako pishesh 2 e dvoichna,
        //ako pishesh 16 e shestnaisetichna
        int result = 200;
        Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '#'));
    }
}

