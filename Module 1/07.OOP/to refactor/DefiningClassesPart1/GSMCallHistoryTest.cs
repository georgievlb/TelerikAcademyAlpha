using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart1
{
    public class GSMCallHistoryTest
    {
        public static void Test()
        {
            GSM LG = new GSM
                ("G4", "LG", "Mary", 28.2M , new Battery("PDO098", 750, 650, BatteryType.NiMH), new Display(15, 55000));
            Call firstcall = new Call();
            firstcall.DateAndTime = new DateTime(2017, 7, 20);
            firstcall.DialedNumber = "0899731333";
            firstcall.DurationInSeconds = 180;

            Call secondcall = new Call();
            firstcall.DateAndTime = new DateTime(2017, 7, 20);
            firstcall.DialedNumber = "0899731333";
            firstcall.DurationInSeconds = 55;

            Call thirdcall = new Call();
            firstcall.DateAndTime = new DateTime(2017, 7, 21);
            firstcall.DialedNumber = "08972133399";
            firstcall.DurationInSeconds = 55;

            Call fourthcall = new Call();
            firstcall.DateAndTime = new DateTime(2017, 7, 22);
            firstcall.DialedNumber = "123";
            firstcall.DurationInSeconds = 67;

            LG.AddCall(firstcall);
            LG.AddCall(secondcall);
            LG.AddCall(thirdcall);
            LG.AddCall(fourthcall);

            firstcall.PrintCallDetails();
            secondcall.PrintCallDetails();
            thirdcall.PrintCallDetails();
            fourthcall.PrintCallDetails();
           
            decimal totalPrice = LG.CalcCallPrice(firstcall, 0.37M) + 
                LG.CalcCallPrice(secondcall, 0.37M) + 
                LG.CalcCallPrice(thirdcall, 0.37M) + 
                LG.CalcCallPrice(fourthcall, 0.37M);

            Console.WriteLine($"Total price of calls = {totalPrice}");

            //to implement remove longest call from history

            LG.ClearCalls();
            Console.WriteLine($"Number of calls: {LG.GetCallHistory.Count}.");





        }
    }
}
