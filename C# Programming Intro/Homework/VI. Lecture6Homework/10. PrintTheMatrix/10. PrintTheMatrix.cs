using System;

class printTheMatrix
{
    static void Main()
    {
        int n = 4;
        for (int counter = 1; counter <= n; counter++)
        {
            //големият цикъл( външният) обхожда редовете, малкият(вътрешният) пълни елементите в тях.
            //мисли за това как стойността на първия for влияе на това, което отпечатва малкия цикъл
            //примерно от коя до коя стойност печати малкия(вътрешния) цикъл, и как тези стойности са свързани с
            //големия цикъл
            for (int i = counter; i <= counter + (n - 1); i++)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }
    }
}