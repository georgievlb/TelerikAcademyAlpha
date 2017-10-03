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
    public class Train : Vehicle, ITrain
    {
        private int carts;


        public Train(int passengerCapacity, decimal pricePerKilometer, int carts) 
            : base(passengerCapacity, pricePerKilometer)
        {
            Validator.CheckIfNumberValueIsValid(passengerCapacity, 30, 150,
                "A train cannot have less than 30 passengers or more than 150 passengers.");
            this.Type = VehicleType.Land;
            this.Carts = carts;
        }

        public int Carts
        {
            get
            {
                return this.carts;
            }
            private set
            {
                Validator.CheckIfNull(value);
                Validator.CheckIfNumberValueIsValid(value, 1, 15, 
                    "A train cannot have less than 1 cart or more than 15 carts.");

                this.carts = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Train ----\nPassenger capacity: {0}\nPrice per kilometer: {1}\nVehicle type: {2}\nCarts amount: {3}", 
                this.PassengerCapacity,
                this.PricePerKilometer,
                this.Type,
                this.Carts);
        }
    }
}