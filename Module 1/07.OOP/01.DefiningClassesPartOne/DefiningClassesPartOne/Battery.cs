using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPartOne
{
    class Battery
    {


        public Battery()
            :this("Samsung", 100, 40, BatteryType.LiIon)//used these values for the sake of exercise
        {

        }
        public Battery(string model, int hoursIdle, int hoursTalks, BatteryType batteryType)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = HoursTalk;
            this.batteryType = batteryType;
        }
        public string Model
        {
            get;
            set;
        }

        public int HoursIdle
        {
            get;
            set;
        }

        public int HoursTalk
        {
            get;
            set;
        }

        private BatteryType batteryType;

        public override string ToString()
        {
            return $"Model = {this.Model}; Hours Idle: {this.HoursIdle}";
        }
    }
}
