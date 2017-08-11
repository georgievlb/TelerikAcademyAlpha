using OlympicGames.Olympics.Contracts;
using OlympicGames.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympicGames.Olympics.Models
{
    public class Sprinter : Olympian, ISprinter
    {
        private IDictionary<string, double> personalRecords; //= new Dictionary<string, double>();
                
        public IDictionary<string, double> PersonalRecords
        {
            get
            {
                return this.personalRecords;
            }
            
        }

        public Sprinter(string firstName, string lastName, string country, IDictionary<string, double> personalRecords) 
            : base(firstName, lastName, country)
        {
            personalRecords.ValidateIfNull();
            this.personalRecords = personalRecords;

        }
        
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            
            foreach (var record in personalRecords)
            {
                builder.Append(string.Format("{0}m: {1}s\n", record.Key, record.Value));
            }
            //Console.WriteLine(string.Format("Created Sprinter\nSprinter: {0} {1} from {2}\nPERSONAL RECORDS: ", 
            //this.FirstName, this.LastName, this.Country));
                     
            //foreach (var record in personalRecords)
            //{
            //    Console.WriteLine( "{0}m: {1}s", record.Key, record.Value);               
            //}
                        
            return string.Format("Created Sprinter\nSPRINTER: {0} {1} from {2}\nPERSONAL RECORDS:\n",
            this.FirstName, this.LastName, this.Country) + builder.ToString();
        }
    }
}
