using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> cityNameToPopulationMap = new Dictionary<string, int>();
            //отляво седи тима на generic-a, демек стринг
            cityNameToPopulationMap.Add("Sofia", 1000000);
            cityNameToPopulationMap.Add("Varna", 500000);
            cityNameToPopulationMap.Add("Silistra", 10000);
            cityNameToPopulationMap.Add("Burgas", 500000);
            cityNameToPopulationMap.Add("Botevgrad", 80000);
            //keys must be different, values may be the same, e.g. two cities may have the same population

            foreach (var element in cityNameToPopulationMap)
            {
                Console.WriteLine($"City:{element.Key} Population: {element.Value}");
            }

        }
    }
}
