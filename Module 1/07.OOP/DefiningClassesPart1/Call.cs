using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart1
{
    public class Call
    {
        public DateTime DateAndTime { get; set; }
        public string DialedNumber { get; set; }
        public decimal DurationInSeconds { get; set; }

        public void PrintCallDetails()
        {
            Console.WriteLine($"Date of the call: {this.DateAndTime}");
            Console.WriteLine($"Number dialed: {this.DialedNumber}");
            Console.WriteLine($"Call duration {this.DurationInSeconds} seconds");
        }

    }
}
