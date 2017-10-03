using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveller.Enums;
using Traveller.Models.Vehicles.Contracts;
using Traveller.Utils;

namespace Traveller.Models.Vehicles
{
    public abstract class Vehicle : IVehicle
    {
        private int passengerCapacity;
        private decimal price;
        private VehicleType type;

        public Vehicle(int passengerCapacity, decimal pricePerKilometer)
        {
            this.PassengerCapacity = passengerCapacity;
            this.PricePerKilometer = pricePerKilometer;
        }

        public int PassengerCapacity
        {
            get
            {
                return this.passengerCapacity;
            }
            set
            {
                Validator.CheckIfNull(value);
                //how do I check if the value is negative?
                if (0 > value || value > 800)
                {
                    throw new ArgumentOutOfRangeException("A vehicle with less than 1 passengers or more than 800 passengers cannot exist!");
                }
                this.passengerCapacity = value;
            }
        }

        public decimal PricePerKilometer
        {
            get
            {
                return this.price;
            }
            private set
            {
                Validator.CheckIfNull(value);
                Validator.PriceCheck(value, 0.10M, 2.50M, 
                    "A vehicle with a price per kilometer lower than $0.10 or higher than $2.50 cannot exist!");
                
                this.price = value;
            }
        }

        public VehicleType Type //трябва да е abstract
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }

        //public override string ToString()
        //{
        //    return // builder to string
        //}
    }
}
