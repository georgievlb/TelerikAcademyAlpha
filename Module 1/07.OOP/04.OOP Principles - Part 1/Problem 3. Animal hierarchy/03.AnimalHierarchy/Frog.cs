using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    public class Frog : Animal, ISound
    {
        

        public Frog()
            :base()
        {

        }

        public Frog(string name)
            :base(name)
        {

        }
        public Frog(string name, int age)
            :base(name, age)
        {

        }
        public Frog(string name, int age, Sex sex)
            : base(name, age, sex)
        {

        }
        public void MakeSound()
        {
            Console.WriteLine("I'm a frog croak...croak.");
        }
    }
}
