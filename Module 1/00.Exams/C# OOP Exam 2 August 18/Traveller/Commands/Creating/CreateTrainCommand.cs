using System;
using System.Collections.Generic;
using Traveller.Commands.Contracts;
using Traveller.Core.Contracts;

namespace Traveller.Commands.Creating
{
    public class CreateTrainCommand : CreateVehicleCommand, ICommand
    {
        public CreateTrainCommand(ITravellerFactory factory, IEngine engine) 
            : base(factory, engine)
        {
        }

        //private readonly ITravellerFactory factory;
        //private readonly IEngine engine;

        //public CreateTrainCommand(ITravellerFactory factory, IEngine engine)
        //{
        //    this.factory = factory;
        //    this.engine = engine;
        //}

        public override string Execute(IList<string> parameters)
        {
            int passengerCapacity;
            decimal pricePerKilometer;
            int cartsCount;

            try
            {
                passengerCapacity = int.Parse(parameters[0]);
                pricePerKilometer = decimal.Parse(parameters[1]);
                cartsCount = int.Parse(parameters[2]);
            }
            catch
            {
                throw new ArgumentException("Failed to parse CreateTrain command parameters.");
            }

            var train = this.Factory.CreateTrain(passengerCapacity, pricePerKilometer, cartsCount);
            this.Engine.Vehicles.Add(train);

            return $"Vehicle with ID {Engine.Vehicles.Count - 1} was created.";
        }
    }
}
