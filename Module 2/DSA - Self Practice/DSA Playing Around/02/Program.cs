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
            Dictionary<string, List<int>> cityNameToPopulationMap = new Dictionary<string, List<int>>();
            //отляво седи тима на generic-a, демек стринг
            cityNameToPopulationMap.Add("Sofia", new List<int>() { 1000000, 20});
            cityNameToPopulationMap.Add("Varna", new List<int>() { 600000, 26 });
            cityNameToPopulationMap.Add("Silistra", new List<int>() { 50000, 24 });
            cityNameToPopulationMap.Add("Burgas", new List<int>() { 500000, 21 });
            cityNameToPopulationMap.Add("Botevgrad", new List<int>() { 40000, 23 });
            //keys must be different, values may be the same, e.g. two cities may have the same population

            foreach (var element in cityNameToPopulationMap)
            {
                Console.WriteLine($"City:{element.Key} Population: {element.Value[0]} Temperature: {element.Value[1]}");
            }
            Console.WriteLine($"Temperature in Varna " + $"{cityNameToPopulationMap["Varna"][1]}");
        }
    }
    
}
