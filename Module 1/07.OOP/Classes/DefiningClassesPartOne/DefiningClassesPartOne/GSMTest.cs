using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPartOne
{
    class GSMTest
    {

        public static void Test()
            //this is incomplete
        {
            GSM gsmNote = 
            new GSM("Note 7", "Samsung", 800, "Gosho",
            new Battery("Samsung", 400, 10, BatteryType.LiIon),
            new Display(800, 50));

            
            GSM[] gsms = new GSM[] { GSM.IPhone4s, gsmNote };
        }


    }
}
