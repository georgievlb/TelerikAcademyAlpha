using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    public class Tomcat : Cat
    {
        public Tomcat()
            : base()
        {

        }
        public Tomcat(string name)
            : base(name)
        {

        }
        public Tomcat(string name, int age)
            : base(name, age)
        {

        }

        public new Sex sex                  //може и в класа Animal, getter-a да е virtual и тука 
                                            //вместо new се пише override
        {
            get { return Sex.Male; }
            set { sex = value; }
        }
    }
}
