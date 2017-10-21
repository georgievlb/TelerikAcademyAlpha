using System;

class OtherOperators
{
    static void Main()
    {
        //+ e string concatenation
        string first = "edno";
        string second = "dve";
        string third = first + second;
        Console.WriteLine(first + second);
        Console.WriteLine(third);
        //member access operator .
        //tova e operatoryt tochka .
        //dava dostup do funkciqta Parse na tipa int
        //int.Parse

        //[] za masiv
        // (type) s nego se castva
        //e.g.
        int a = 64;
        Console.WriteLine((char) a);

        //terniary operator:
        //b ? x :y
        //b e bulev izraz
        //ako e true se izpylnqva purvoto, ako ne vtoroto
        Console.WriteLine(5 > 7 ? 5 : 7);

        Console.WriteLine(DateTime.Now);
    }
}

