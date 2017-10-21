using System;

class sumFibonacciNumbers

{
    static void Main()
    {
        int n = 15;
        int a = 1;
        int b = 1;
        int sum = a + b;
        
        for (int i = 0; i < 15; i++)
        {
            int temp = a;           //1
            a = b;                  //1
            b += temp;              //2
            sum += temp + b;
            
           
            Console.WriteLine("Fibonacci No.{0}: {1}....", i, temp);


        }
    }
}




