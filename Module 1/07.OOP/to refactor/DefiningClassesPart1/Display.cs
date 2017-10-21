using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart1
{
    public class Display
    {
        private int Size;
        private int NumberOfColors;

        public Display()
        {

        }
        public Display(int size)
        {
            this.Size = size;
        }
        public Display(int size, int numberOfColors)
            :this(size)
        {
            this.NumberOfColors = numberOfColors;
        }

        public int GetDisplaySize
        {
            get { return this.Size; }
            set { Size = value; }
        }
        public int GetNumberOfColors
        {
            get { return this.NumberOfColors; }
            set { NumberOfColors = value; }
        }

        public override string ToString()
        {
            return $"Size overriden  = {this.Size}";
        }
    }
}
