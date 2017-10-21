using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    public class Cat : Animal, ISound
    {
        public Cat()
            :base()
        {

        }

        public Cat(string name)
            :base(name)
        {

        }
        public Cat(string name, int age)
            :base(name, age)
        {

        }
        public Cat(string name, int age, Sex sex)
            :base(name, age, sex)
        {

        }

        public void MakeSound()
        {
            Console.WriteLine("Cats go MEOW.");
        }
    }
}
