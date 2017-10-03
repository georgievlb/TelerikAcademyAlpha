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
    public class Bus : Vehicle, IBus
    {
        public Bus(int passengerCapacity, decimal pricePerKilometer) 
            : base(passengerCapacity, pricePerKilometer)
        {
            Validator.CheckIfNumberValueIsValid(passengerCapacity, 10, 50,
                "A bus cannot have less than 10 passengers or more than 50 passengers.");
            this.Type = VehicleType.Land;
        }

        public override string ToString()
        {
            return string.Format("Bus ----\nPassenger capacity: {0}\nPrice per kilometer: {1}\nVehicle type: {2}",
                this.PassengerCapacity,
                this.PricePerKilometer,
                this.Type);
        }
    }
}
