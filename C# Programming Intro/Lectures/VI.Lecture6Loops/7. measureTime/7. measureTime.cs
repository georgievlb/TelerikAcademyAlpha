using System;

class MeasureTime
{
    static void Main()
    {
        DateTime startTime = DateTime.Now;
        Console.WriteLine(DateTime.Now);
        long sum = 0;
        for (int i = 0; i < 300000000; i++)
        {
            sum += i;
        }
        Console.WriteLine(sum);
        Console.WriteLine(DateTime.Now);
        DateTime finishTime = DateTime.Now;

        //C# allows you to make calculations with time e.g. minutes/hours!
        Console.WriteLine(finishTime - startTime);
    }
}
