using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPartOne
{
    class GSMCallHistoryTest
    {
        public static void Test()
        {
            //tuka si igraeme s instrukciite 
            //this is incomplete

            GSM iPhone5S = new GSM("IPhone5S", "Apple", 800, "Pesho",
            new Battery("AppleBattery", 400, 10, BatteryType.LiIon),
            new Display(800, 50));

            Calls firstCall = new Calls();
            firstCall.DateTime = new DateTime();
            firstCall.DialedPhoneNumber = "21313133";
            firstCall.DurationInSeconds = 60;
            
            
        }
    }
}
