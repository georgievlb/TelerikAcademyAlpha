using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Recursion
{
    class Program
    {
        static decimal Factorial(decimal num)
        {
            
            //обикновено дъното на рекурсията се пише горе. Като се прави рекурсия, се почва от дъното.
            //Нулевите тестове са ти дъното.
            //коя е тази стойност на рекурсията, която знаем? тя е дъното.
            if (num == 0)
            {
                return 1;
            }
            
            decimal result = 0; result += num * Factorial(num - 1);
            return result;
        }

        static void Main()
        {
            Console.WriteLine(Factorial(5));
        }
    }
}
