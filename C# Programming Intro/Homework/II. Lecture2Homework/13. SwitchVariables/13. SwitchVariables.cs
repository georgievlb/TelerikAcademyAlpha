using System;

    class SwitchVariables
    {
        static void Main(string[] args)
        {
        int a = 5;
        int b = 10;
        Console.WriteLine(a);
        Console.WriteLine(b);
        int c = a;
        a = b;
        b = c;
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine("New values");
        int d = 5;
        int e = 10;
        Console.WriteLine(d);
        Console.WriteLine(e);
        d = d + e;  // d = 15
       
        e = d - e;  // e = 5
        d = d - e;
        Console.WriteLine(d);
        Console.WriteLine(e);
        
        //e = d - e;  // e = 5
        //d = d - e;  // d = 10 
        //Console.WriteLine(c);
        //Console.WriteLine(d);
            
        }

    }

