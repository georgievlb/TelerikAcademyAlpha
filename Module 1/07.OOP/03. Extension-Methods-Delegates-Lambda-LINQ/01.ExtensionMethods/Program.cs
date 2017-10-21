using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    using System;

    public static class Example
    {
        public static void Main()
        {
            string exampleString = "Hello Extension Methods";
            int wordsInString = exampleString.WordCount();
            Console.WriteLine(wordsInString);
        }
    }

    public static class Extensions
    {
        public static int WordCount(this string str)// ако махнем this няма да е като extension method
            //и трябва да го достъпваме с Extensions.WordCount()
        {
            return str.Split(new char[] { ' ', '.', '?' },
            StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }

}

namespace ExntensionMethods2
{
    public static class Example
    {
        public static void Main()
        {
            List<int> integers = new List<int> { 1, 2, 3, 4, 5 };
            integers.IncreaseWith(5);
            Console.WriteLine(string.Join(", ", integers));
        }
    }

    public static class Extensions
    {
        public static void IncreaseWith(this IList<int> list, int amount)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i] += amount;
            }
        }
    }
}