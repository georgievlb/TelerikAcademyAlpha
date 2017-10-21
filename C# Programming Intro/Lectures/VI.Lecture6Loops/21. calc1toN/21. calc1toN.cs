using System;

class CalcOnetoN
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }
        Console.WriteLine("The sum of {0} to {1} is {2}", 1, n, sum);
    }
}

//EXAMPLE FROM C# TEXTBOOK
//Console.Write("n = ");
//int n = int.Parse(Console.ReadLine());
//int num = 1;
//int sum = 1;
//Console.Write("The sum 1");
//while (num<n)
//{
//            num++;
//            sum += num;
//            Console.Write(" + " + num);
//}
//Console.WriteLine(" = " + sum);