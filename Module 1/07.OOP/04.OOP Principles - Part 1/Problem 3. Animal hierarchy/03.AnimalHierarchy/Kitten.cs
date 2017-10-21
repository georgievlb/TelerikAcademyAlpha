using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    public class Kitten : Cat
    {
        public Kitten()
            :base()
        {

        }
        public Kitten(string name)
            :base(name)
        {

        }
        public Kitten(string name, int age)
            :base(name, age)
        {

        }
        
        public new Sex sex                  //може и в класа Animal, getter-a да е virtual и тука 
                                            //вместо new се пише override
        {
            get { return Sex.Female; }
            set { sex = value; }
        }
    }
}
