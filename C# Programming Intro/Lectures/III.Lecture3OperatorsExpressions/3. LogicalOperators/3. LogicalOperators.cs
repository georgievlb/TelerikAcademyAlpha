using System;

class LogicalOperators
{
    static void Main()
    {
        bool a = true;
        bool b = false;
        Console.WriteLine(a && b);  //false
        Console.WriteLine(a || b);  //true
        Console.WriteLine(!b);      //true
        Console.WriteLine(b || true); //true
        Console.WriteLine((5 > 7) ^ (a==b)); //false
        Console.WriteLine(b || false); // false

        //De Morgan's Law
        //!(a && b) == (!a || !b)
        //!(a || b) == (!a && !b)

    }
}

