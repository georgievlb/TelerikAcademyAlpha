using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPartOne
{
    public class Display
    {
        public Display()
            :this(0, 0)//po princip ne se pravi
        {

        }
        public Display(double size, int numberOfColors)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }
             
            
        //
        //fields - camelCase
        //започваме с 2 пропъртита; обикновено се работи с пропъртита Property = PascalCase
        public double Size
        {
            get;
            set;
        }

        public int NumberOfColors
        {
            get;
            set;
        }
        public override string ToString()
        {
            return $"Size = {this.Size}";
        }
    }
}
