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
            Dictionary<string, City> cityNameToPopulationMap = new Dictionary<string, City>();
            //отляво седи тима на generic-a, демек стринг
            cityNameToPopulationMap.Add("Sofia", new City() {Name = "Sofia", Population = 10000000, OldName = "Serdika", Temperature = 30 });
            
            //keys must be different, values may be the same, e.g. two cities may have the same population

            foreach (var element in cityNameToPopulationMap)
            {
                Console.WriteLine($"City:{element.Value.Name} Population: {element.Value.Population} Temperature: {element.Value.Temperature} Old Name: {element.Value.OldName}");
            }
            //дали съдържа такъв ключ:
            //cityNameToPopulationMap.Contains();
        }
    }

    public class City
    {
        public string Name { get; set; }
        public int Population { get; set; }
        public string OldName { get; set; }
        public double Temperature { get; set; }
    }
}
