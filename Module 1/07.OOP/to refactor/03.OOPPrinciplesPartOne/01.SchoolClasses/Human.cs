using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciplesPartOne
{
    public class Human
    {
        private string Name;

        public Human()
        {

        }

        public Human(string name)
        {
            this.Name = name;
        }

        public string GetName
        { get { return this.Name; }

        }

        //public static void PrintName()
        //{
            
        //    Console.WriteLine(Human.Name);
        //}
    }
}
