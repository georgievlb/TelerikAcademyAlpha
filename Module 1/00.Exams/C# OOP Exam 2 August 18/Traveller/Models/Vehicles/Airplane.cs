using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveller.Enums;
using Traveller.Models.Vehicles.Contracts;

namespace Traveller.Models.Vehicles
{
    public class Airplane : Vehicle, IAirplane
    {
        private bool hasFreeFood;

        public Airplane(int passangerCapacity, decimal pricePerKilometer, bool hasFreeFood) 
            : base(passangerCapacity, pricePerKilometer)
        {
            this.Type = VehicleType.Air;
            this.HasFreeFood = hasFreeFood;
        }

        public bool HasFreeFood
        {
            get
            {
                return this.hasFreeFood;
            }
            private set
            {
                this.hasFreeFood = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Airplane ----\nPassenger capacity: {0}\nPrice per kilometer: {1}\nVehicle type: {2}\nHas free food: {3}",
                this.PassengerCapacity,
                this.PricePerKilometer,
                this.Type,
                this.HasFreeFood);
        }
    }
}
