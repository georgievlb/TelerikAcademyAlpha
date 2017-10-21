using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    public class Animal : IEnumerable
    {
        private string Name;
        private int Age;
        private Sex Sex;

        private Animal[] animals = new Animal[5];
        private int freeIndex = 0;


        public Animal(string name)
        {
            this.Name = name;
        }
        public Animal(string name, int age)
            :this(name)
        {
            this.Age = age;
        }
        public Animal(string name, int age, Sex sex)
            :this(name, age)
        {
            this.Sex = sex;
        }

        public string name
        {
            get { return this.Name; }
            set { Name = value; }
        }
        public int age
        {
            get { return this.Age; }
            set { Age = value; }
        }
        public Sex sex
        {
            get { return this.Sex; }
            set { Sex = value; }
        }


        
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
