using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPartOne
{
   
    class Program
    {
        static void Main(string[] args)
        {
            //ako okomplektovame obekt polzvame konstruktora
            GSM gsm = new GSM("Note 7", " Samsung")
            {
                Price = 1000M,
                Owner = "Lucho",
                Battery = new Battery("Samsung", 100, 40, BatteryType.LiIon),
                Display = new Display(1024, 1024),
            };
            Console.WriteLine(gsm);
            //Console.WriteLine(gsm.IPhone4s);


            //the below code is for abstraction and interfaces
            List<Calls> firstCallHistory = new List<Calls>()
            {
                new Calls() {DurationInSeconds = 15},
                new Calls() {DurationInSeconds = 25},
                new Calls() {DurationInSeconds = 35},
            };

            HashSet<Calls> thirdCallHistory = new HashSet<Calls>()  //lookup HashSet!
            {
                new Calls() {DurationInSeconds = 11},
                new Calls() {DurationInSeconds = 23},
                new Calls() {DurationInSeconds = 30},
            };

            decimal firstPrice = GSM.CalculateCallsPrice(firstCallHistory);
            //
            // decimal second
            //decimal third

            Console.WriteLine(firstPrice);
        }
    }
}
