using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveller.Models.Contracts;
using Traveller.Models.Vehicles.Contracts;
using Traveller.Utils;

namespace Traveller.Models.TravellingItems
{
    public class Journey : IJourney
    {
        private string destination;
        private int distance;
        private string startLocation;
        private IVehicle vehicle;

        public Journey(string startLocation, string destination, int distance, IVehicle vehicle)
        {
            this.StartLocation = startLocation;
            this.Destination = destination;
            this.Distance = distance;
            this.Vehicle = vehicle;
        }

        public string Destination
        {
            get
            {
                return this.destination;
            }
            private set
            {
                Validator.CheckIfStringLengthIsValid(value, 5, 25, 
                    "The Destination's length cannot be less than 5 or more than 25 symbols long.");

                this.destination = value;
            }
        }

        public int Distance
        {
            get
            {
                return this.distance;
            }
            private set
            {
                Validator.CheckIfNumberValueIsValid(value, 5, 5000, 
                    "The Distance cannot be less than 5 or more than 5000 kilometers.");

                this.distance = value;
            }
        }

        public string StartLocation
        {
            get
            {
                return this.startLocation;
            }
            private set
            {
                Validator.CheckIfStringLengthIsValid(value, 5, 25,
                    "The StartingLocation's length cannot be less than 5 or more than 25 symbols long.");

                this.startLocation = value;
            }
        }

        public IVehicle Vehicle
        {
            get
            {
                return this.vehicle;
            }
            private set
            {
                this.vehicle = value;
            }
        }

        public decimal CalculateTravelCosts()
        {
            return this.Distance * this.Vehicle.PricePerKilometer;
            //pokazva tipa na vehicle-a:
            //Console.WriteLine(this.vehicle.Type);
        }

        public override string ToString()
        {
            return string.Format("Journey ----\nStart location: {0}\nDestination: {1}\nDistance: {2}\nVehicle type: {3}\nTravel costs: {4}", 
                this.StartLocation, 
                this.Destination, 
                this.Distance, 
                this.Vehicle.Type, 
                this.CalculateTravelCosts());
        }
    }
}
