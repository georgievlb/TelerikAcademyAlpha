using System;
namespace Delegates
{
    // Declaration of a delegate
    public delegate void SimpleDelegate(string param);

    public class Example
    {
        public static void TestMethod(string param) //param moje da se kazva i pesho не е като онова params с много параметри
        {
            Console.WriteLine("I was called by a delegate.");
            Console.WriteLine("I got parameter: {0}.", param);
        }

        public static void Main()
        {
            // Instantiate the delegate
            SimpleDelegate exampleDelegate = new SimpleDelegate(TestMethod);

            // Invocation of the method, pointed by delegate
            exampleDelegate("test");
        }
    }
}