using System;
using System.Text;

class cardsDeck
{
    static void Main()
    {
        
        for (int i = 2; i <= 14; i++)
        {
          
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("{0} \u2660", i);
            for (int j = i; j < 14; j++)
            {
                Console.Write("J");
            }
            //copyright symbol
            //Console.WriteLine("\u00A9");
            //playing cards suits
            //Console.Write("\u2663");
            

        }
    }
}

