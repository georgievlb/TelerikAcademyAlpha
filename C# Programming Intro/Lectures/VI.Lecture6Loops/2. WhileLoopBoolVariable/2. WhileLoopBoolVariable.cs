using System;

class WhileLoopExample
{
    static void Main()
    {
        bool exit = false;
        int counter = 0;
        while (!exit)
        {
            int num = Int32.Parse(Console.ReadLine());
            if (num == 0)
            {
                exit = true;
            }
            else
                Console.WriteLine(num * 5);

        }
    }
}
