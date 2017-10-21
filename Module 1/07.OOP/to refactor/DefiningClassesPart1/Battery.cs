using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart1
{
    public class Battery
    {
        private string BatteryModel;
        private int HoursTalk;
        private int HoursIdle;
        private BatteryType BatteryType;

        public Battery()
        {

        }
        public Battery(string batteryModel)             //constructor with 1 parameter
        {
            this.BatteryModel = batteryModel;
        }
        public Battery(int hoursIdle, int hoursTalk)    //constructor with 2 parameters
        {
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }
        public Battery(BatteryType batteryType)
        {
            this.BatteryType = batteryType;
        }
        public Battery(string batteryModel, int hoursIdle, int hoursTalk)
            : this(hoursIdle, hoursTalk)
        {
            this.BatteryModel = batteryModel;
        }
        public Battery(string batteryModel, int hoursIdle, int hoursTalk, BatteryType batteryType)
            : this(batteryModel, hoursIdle, hoursTalk)
        {
            this.BatteryType = batteryType;
        }

        public string GetBatteryModel
        {
            get { return this.BatteryModel; }
            set { BatteryModel = value; }
        }
        public BatteryType GetBatteryType
        {
            get { return this.BatteryType; }
            set { BatteryType = value; }
        }
        public int GetHoursTalk
        {
            get { return this.HoursTalk; }
            set { HoursTalk = value; }
    }
        public int GetHoursIdle
        {
            get { return this.HoursIdle; }
            set { HoursIdle = value; }
        }



    }
}
