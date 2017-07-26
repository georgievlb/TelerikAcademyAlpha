using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciplesPartOne
{
    public class Student: Human
    {
        private int GroupNumber;

        public Student()
            :base()
        {

        }

        public Student(string name)
            :base(name)
        {

        }
        public Student(string name, int groupNumber)
            :base(name)
        {
            this.GroupNumber = groupNumber;
        }

        public int GetGroupNo
        {
            get { return this.GroupNumber; }
        }

    }
}
