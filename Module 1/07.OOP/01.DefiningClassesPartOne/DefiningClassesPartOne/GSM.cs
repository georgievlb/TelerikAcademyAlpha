using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPartOne
{
    class GSM   //много рядко цялото име на класа е с главни букви
    {
        private string model;           //we need private fields, fields are always private
        private string manufacturer;
        private decimal? price;     //? = null
        private string owner;
        //private Battery battery;  //we dont need these right now
        //private Display display;
        private List<Calls> callHistory;

        private static GSM iPhone4S = new GSM("IPhone4S", "Apple", 800, "Pesho", 
            new Battery("Samsung", 400, 10, BatteryType.LiIon),
            new Display(800, 50));


        //почва се от конструкта с най-много параметри и след това над него си пишеш тези с по-малко
        public GSM (string model, string manufacturer)
            :this (model, manufacturer, 0, null, null, null)
        {

        }
        public GSM(string model, string manufacturer, decimal? price, 
            string owner, Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display; //konstruktora ni trqbwa za da imame nachalni stoinosti
            this.CallHistory = new List<Calls>();

            
        }

        public static GSM IPhone4s //propertyto e PasclCase
        {
            get
            {
                return iPhone4S;
            }
        }
        //propertitata ni pozvolqvat da modificirame nachalnata stoinost, no za celta trqbwa da ima nachalna stoinost, s koqto da rabotqt
        public string Model     //почва се от пропъртитата,а не от филдовете
            //всяко нещо извън нашия клас, нашият клас счита а външния свят, това трябва да са пропъртита,
            // а не филдове
        {
            get
            {
                return this.model;
            }
            set
            {
                //ot tuka se pravi validaciq - v setterite, validira se stoinostta, koqto idva ot vunshniq svqt
                if(string.IsNullOrWhiteSpace(value))        //validirame stoinostta, koqto idva v nasheto property a ne stoinostta koqto imame vyv fiilda
                {
                    throw new ArgumentException("The model should not be null or empty");      
                        
                        //moje i bez exception da ima validaciq, zavisi ot situaciqta
                }
                this.model = value; //като напишеш само get; set; microsoft sa nakodili eto tova, ima fildove ama ne se vijdat
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                //ot tuka se pravi validaciq - v setterite, validira se stoinostta, koqto idva ot vunshniq svqt
                if (string.IsNullOrWhiteSpace(value))        //validirame stoinostta, koqto idva v nasheto property a ne stoinostta koqto imame vyv fiilda
                {
                    throw new ArgumentException("The manufacturer should not be null or empty");

                    //moje i bez exception da ima validaciq, zavisi ot situaciqta
                }
                this.manufacturer = value; //като напишеш само get; set; microsoft sa nakodili eto tova, ima fildove ama ne se vijdat
            }
        }

        public decimal? Price //? това значи че всичко е null
        {
            get
            {
                return this.price;
            }
            set
            {
                //ot tuka se pravi validaciq - v setterite, validira se stoinostta, koqto idva ot vunshniq svqt
                if (value.HasValue && value.Value < 0)        //validirame stoinostta, koqto idva v nasheto property a ne stoinostta koqto imame vyv fiilda
                {
                    throw new ArgumentException("The price should not be negative");

                    //moje i bez exception da ima validaciq, zavisi ot situaciqta
                }
                this.price = value; //като напишеш само get; set; microsoft sa nakodili eto tova, ima fildove ama ne se vijdat
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                //ot tuka se pravi validaciq - v setterite, validira se stoinostta, koqto idva ot vunshniq svqt
                if (value == string.Empty)        //validirame stoinostta, koqto idva v nasheto property a ne stoinostta koqto imame vyv fiilda
                {
                    throw new ArgumentException("The owner should not be empty");

                    //moje i bez exception da ima validaciq, zavisi ot situaciqta
                }
                this.owner = value; //като напишеш само get; set; microsoft sa nakodili eto tova, ima fildove ama ne se vijdat
            }
        }

        public Battery Battery  //property of type Battery
        {
            get;
            set;
        }

        public Display Display
        {
            get;
            set;
        }

        public override string ToString()
        {
            //return base.ToString(); alternative syntax
            return $"model: {this.Model}\nManufacturer: {this.Manufacturer}\nPrice: {this.Price}\nOwner: {this.Owner}\nDisplay: {this.Display}\nBattery: {this.Battery}";
        }

        public List<Calls> CallHistory
        {
            get
            {
                return this.callHistory;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentException("Call history should not be null");
                }

                this.callHistory = value;
            }
                
                
                //tuka e private za da ne ni setne nqkoi drug spisuka
        }

        public static decimal CalculateCallsPrice(List<Calls> calls)        //пример за абстракция и интерфейси
        {   //ako smenim IEnumerable s List pak shte raboti
            //koda se kompilira zashtoto i trite 
            decimal price = 0;
            foreach(Calls call in calls)
            {
                price += call.DurationInSeconds * 10;                       //ползваме IEnumerable
            }

            calls.Clear();
            return price;                                                   //пример за абстракция и интерфейси
        }

        public void AddCall(Calls call)
        {
            this.CallHistory.Add(call);
        }
        public void RemoveCall(Calls call)
        {
           if( !this.CallHistory.Contains(call))
            {
                throw new ArgumentException("call is not found");
            }

            this.CallHistory.Remove(call);
        }

        public void ClearCalls() // this is incomplete
        {
            this.CallHistory.Clear();
        }

        public decimal GetCallPrice()
        {
            //polzvame foreach za smetka na baza Call History-to
            return 0;
        }
    }
}
//practical use of private setter:
//dostupvame propertytto no ne muz adavame stoinost kakvato iskame primerno nula i tn, togava se polzva
//private setter;

    //getter + readonly fiel;d nai chesto se polzva, private setter po rqdko