using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart1
{


    public class GSM
    {
        private string GsmModel;
        private string Manufacturer;
        private decimal? Price;
        private string Owner;
        private Battery GsmBattery;
        private Display Display;
        private static GSM IPhone4s = new GSM
            ("IPhone 4s", "Apple", "Lucho", 100, new Battery("1203PD", 700, 890, BatteryType.LiIon), new Display(12, 60000));
        private List<Call> CallHistory = new List<Call>();

        public GSM()
        {

        }
        public GSM(string gsmModel)
        {
            this.GsmModel = gsmModel;
        }
        public GSM(string gsmModel, string manufacturer)
            : this(gsmModel)
        {
            this.Manufacturer = manufacturer;
        }
        public GSM(int price)
        {
            this.Price = price;
        }
        public GSM(Battery gsmBattery)
        {
            this.GsmBattery = gsmBattery;
        }
        public GSM(Display display)
        {
            this.Display = display;
        }
        public GSM(string gsmModel, string manufacturer, string owner, decimal price, Battery battery, Display display)
             : this(gsmModel, manufacturer)
        {
            this.Owner = owner;//constr
            this.Price = price;//constr
            this.GsmBattery = battery;
            this.Display = display;
        }
             
        public string GetGsmModel
        {
            get { return this.GsmModel; }
            set { GsmModel = value; }
        }
        public string GetManufacturer
        {
            get { return this.Manufacturer; }
            set { Manufacturer = value; }
        }
        public decimal? GetPrice
        {
            get { return this.Price; }
            set { Price = value; }
        }
        public string GetOwner
        {
            get { return this.Owner; }
            set { Owner = value; }
        }
        public string GetGsmBatteryModel
        {
            get { return this.GsmBattery.GetBatteryModel; }
            set { GsmBattery.GetBatteryModel = value; }
        }
        public Battery GetGsmBattery
        {
            get { return GsmBattery; }
            set { GsmBattery = value; }
        }
        public Display GetDisplay
        {
            get { return this.Display; }
            set { Display = value; }
        }
        public static GSM GetIPhone4s
        {
            get { return IPhone4s; }            
        }
        public List<Call> GetCallHistory
        {
            get { return this.CallHistory; }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentException("Call history should not be null");
                }

                this.CallHistory = value;
            }
        }




        public void PrintGSMInfo()
        {
            Console.WriteLine($"Model: {this.GsmModel}");
            Console.WriteLine($"Manufacturer: {this.Manufacturer}");
            Console.WriteLine($"Price: {this.Price}");
            Console.WriteLine($"Owner: {this.Owner}");
            Console.WriteLine($"Battery model: {this.GetGsmBatteryModel}");
            Console.WriteLine($"Battery type: {this.GsmBattery.GetBatteryType}");
            Console.WriteLine($"Battery Hours Talk: {this.GsmBattery.GetHoursTalk}");
            Console.WriteLine($"Battery Hours Idle: {this.GsmBattery.GetHoursIdle}");
            Console.WriteLine($"Display size: {this.GetDisplay.GetDisplaySize}");
            Console.WriteLine($"Display number of colors: {this.Display.GetNumberOfColors}");
            Console.WriteLine();

        }
        public void AddCall(Call call)
        {   
            this.CallHistory.Add(call);
        }
        public void RemoveCall(Call call)
        {
            if (!this.CallHistory.Contains(call))
            {
                throw new ArgumentException("Call is not found");
            }

            this.CallHistory.Remove(call);
        }
        public void ClearCalls()
        {
            this.CallHistory.Clear();
        }
        public decimal CalcCallPrice(Call call, decimal pricePerMinute)
        {   
            return (call.DurationInSeconds / 60) * (pricePerMinute);            
        }


    }
}
