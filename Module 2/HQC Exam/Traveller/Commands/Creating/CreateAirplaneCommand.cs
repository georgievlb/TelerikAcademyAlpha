using System;
using System.Collections.Generic;
using Traveller.Commands.Contracts;
using Traveller.Core;
using Traveller.Core.Contracts;
using Traveller.Core.Factories;

namespace Traveller.Commands.Creating
{
    public class CreateAirplaneCommand : CreateObjectCommand, ICommand
    {

        public CreateAirplaneCommand(ITravellerFactory factory, IDatabase database)
            :base(factory, database)
        {
            //this.Factory = factory;
            //this.Database = database;
        }

        //public ITravellerFactory Factory { get; }
        //public IDatabase Database { get; }

        public override string Execute(IList<string> parameters)
        {
            int passengerCapacity;
            decimal pricePerKilometer;
            bool hasFreeFood;

            try
            {
                passengerCapacity = int.Parse(parameters[0]);
                pricePerKilometer = decimal.Parse(parameters[1]);
                hasFreeFood = bool.Parse(parameters[2]);
            }
            catch
            {
                throw new ArgumentException("Failed to parse CreateAirplane command parameters.");
            }

            var airplane = TravellerFactory.Instance.CreateAirplane(passengerCapacity, pricePerKilometer, hasFreeFood);
            this.Database.Vehicles.Add(airplane);

            return $"Vehicle with ID {this.Database.Vehicles.Count - 1} was created.";
        }
    }
}
