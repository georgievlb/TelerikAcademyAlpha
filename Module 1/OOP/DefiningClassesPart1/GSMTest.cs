using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart1
{
    public class GSMTest
    {
        //Create an array of few instances of the GSM class.
        public static void TestTheGSMs()
        {
            GSM Samsung = new GSM("Galaxy", "Samsung", "John", 30, new Battery("233DS", 900, 700, BatteryType.LiIon), new Display(18, 78000));
                        
            GSM HTC = new GSM("One", "HTC", "Kiro", 20, new Battery("909DS", 980, 780, BatteryType.NiCd), new Display(14, 65000));
            
            GSM Sony = new GSM("Xperia", "Sony", "Mira", 28, new Battery("213SXZ", 700, 600, BatteryType.NiMH), new Display(19, 99000));
            
            GSM[] gsms = new GSM[] { Samsung, HTC, Sony, GSM.GetIPhone4s };
            foreach (GSM gsm in gsms)
            {
                gsm.PrintGSMInfo();
            }
        }
    }
}
