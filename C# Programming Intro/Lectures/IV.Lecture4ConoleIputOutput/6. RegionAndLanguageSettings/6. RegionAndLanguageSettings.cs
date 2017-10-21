using System;
//за настройка на culture само за това приложение, без да пипа по настройкитена компютъра
using System.Threading;
using System.Globalization;

class RegionAndLanguageSettings
{
    static void Main()
    {
        //долният ред всъщност задава настройките само за това приложение
        Thread.CurrentThread.CurrentCulture
            = CultureInfo.InvariantCulture;
        double a = 0;
        string line = Console.ReadLine();
        a = double.Parse(line);
        Console.WriteLine(a);

    }
}

