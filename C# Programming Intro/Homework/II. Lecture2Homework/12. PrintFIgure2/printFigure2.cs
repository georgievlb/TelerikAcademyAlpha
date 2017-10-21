using System;

    class PrintFIgure2
    {
        static void Main()
        {
        //char symbol = (char) 0xA9;
        //Console.WriteLine(symbol);
        //Console.WriteLine("\00A9");
        //string copy = "00A9"
        //Console.WriteLine(copy);
        string copyrightUnicode = "00A9";
        int value = int.Parse(copyrightUnicode, System.Globalization.NumberStyles.HexNumber);
        string symbol = char.ConvertFromUtf32(value).ToString();
        Console.WriteLine(symbol);
    }
    }

