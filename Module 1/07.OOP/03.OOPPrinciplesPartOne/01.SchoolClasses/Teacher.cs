using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciplesPartOne
{
    public class Teacher : Human
    {
        private int NumberOfLectures;

        public Teacher()
            :base()
        {

        }

        public Teacher(string name)
            :base(name)
        {

        }
        public Teacher(int numberOfLectures)
        {
            this.NumberOfLectures = numberOfLectures;
        }
        public Teacher(string name, int numberOfLectures)
            :base(name)
        {
            this.NumberOfLectures = numberOfLectures;
        }

        public int GetNumberOfLectures
        {
            get { return this.NumberOfLectures; }
        }
    }
}
