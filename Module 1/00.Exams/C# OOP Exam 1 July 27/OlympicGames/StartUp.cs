using OlympicGames.Core;
using OlympicGames.Olympics.Models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace OlympicGames
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            // Don not touch here (Magic Unicorns)
            Engine.Instance.Run();

            //Boxer player = new Boxer("Peter", "Parker", "USA", BoxingCategory.Featherweight, 0, 100);
            //Sprinter sprinter = new Sprinter("Ivan", "Ivanov", "BGA", new Dictionary<string, double>() { { "100", 9.6 } });
            //Console.WriteLine(sprinter.ToString());
            //Console.WriteLine(sprinter.PersonalRecords.Keys);
            //Console.WriteLine("Key = {0}, Value = {1}", sprinter.PersonalRecords.Keys, sprinter.PersonalRecords.Values);
            //foreach (var kvp in sprinter.PersonalRecords)
            //{
            //    Console.WriteLine($"{kvp.Key}m: {kvp.Value}s");
            //}
            
        }
    }
}
