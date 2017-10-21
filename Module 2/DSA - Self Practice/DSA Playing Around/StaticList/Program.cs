using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Statically implemented list that uses an array, so the list has a fixed size.
namespace StaticList
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomListImplementedWithArray shoppingList = new CustomListImplementedWithArray();

            shoppingList.Add("Milk");
            shoppingList.Add("Honey");
            shoppingList.Add("Olives");
            shoppingList.Add("Beer");
            shoppingList.Remove("Olives");
            Console.WriteLine("We need to buy:");
            for (int i = 0; i < shoppingList.Count; i++)
            {
                Console.WriteLine(shoppingList[i]);
            }
            Console.WriteLine("Do we have to buy Bread? " +
            shoppingList.Contains("Bread"));
        }
    }
}
