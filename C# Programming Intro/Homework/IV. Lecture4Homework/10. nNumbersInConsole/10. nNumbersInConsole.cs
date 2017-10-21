using System;
using System.Text;
namespace nNumbersInConsole
{
    class nNumbersInConsole
    {
        static void Main()
        {
            Console.WriteLine("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            int i = 0;
            int count = n;
            int sum = 0 + n;
            while (i <= n && count > 0)
            {
                
                Console.WriteLine("Enter {0} more number(s)", count);
                int a = int.Parse(Console.ReadLine());
               
                sum = a + sum;
                
                i++;
                --count;
                if (i == n)
                {
                    Console.WriteLine("the sum is: {0}", sum);
                    a = Encoding.UTF32;
                }

            }
        }
    }
}
