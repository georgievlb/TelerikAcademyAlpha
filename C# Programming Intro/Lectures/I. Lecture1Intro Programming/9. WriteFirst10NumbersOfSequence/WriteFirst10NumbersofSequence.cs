using System;

class WriteFirst10NumbersofSequence
{
    static void Main()
    {
        for (int i = 2; i < 20; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
            else if (i % 2 != 0)
            {
                Console.WriteLine(-i);
            }
        }
       
    }
}
