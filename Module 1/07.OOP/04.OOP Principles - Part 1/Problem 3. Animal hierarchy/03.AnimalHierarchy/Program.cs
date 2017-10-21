using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Frog frog1 = new Frog();
            frog1.name = "Erica";
            frog1.age = 25;
            frog1.sex = Sex.Female;
            Console.WriteLine(frog1.name);
            Console.WriteLine(frog1.sex);
            Console.WriteLine(frog1.age);

            Console.WriteLine("------------");

            Frog frog2 = new Frog("Paul", 27, Sex.Male);
            Console.WriteLine(frog2.name);
            Console.WriteLine(frog2.sex);
            Console.WriteLine(frog2.age);

            Cat cat1 = new Cat("Tom", 8, Sex.Male);
            Console.WriteLine(cat1.name);
            Console.WriteLine(cat1.age);
            Console.WriteLine(cat1.sex);



            Kitten kitten1 = new Kitten("Lili", 1);
            Console.WriteLine(kitten1.name);
            Console.WriteLine(kitten1.age);
            Console.WriteLine(kitten1.sex);

            Console.WriteLine("*************");

            Tomcat tomcat1 = new Tomcat("Alfred", 2);
            Console.WriteLine(tomcat1.name);
            Console.WriteLine(tomcat1.age);
            Console.WriteLine(tomcat1.sex)

            Animal[] animals = new Animal { frog1, frog2, }


        }
    }
}
