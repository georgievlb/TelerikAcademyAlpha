using System;
using System.Collections.Generic;
using Traveller.Commands.Contracts;
using Traveller.Core.Contracts;

namespace Traveller.Commands.Creating
{
    public class CreateBusCommand : CreateVehicleCommand, ICommand
    {
        public CreateBusCommand(ITravellerFactory factory, IEngine engine) 
            : base(factory, engine)
        {
        }

        //private readonly ITravellerFactory factory;
        //private readonly IEngine engine;

        //public CreateBusCommand(ITravellerFactory factory, IEngine engine)
        //{
        //    this.factory = factory;
        //    this.engine = engine;
        //}

        public override string Execute(IList<string> parameters)
        {
            int passengerCapacity;
            decimal pricePerKilometer;

            try
            {
                passengerCapacity = int.Parse(parameters[0]);
                pricePerKilometer = decimal.Parse(parameters[1]);
            }
            catch
            {
                throw new ArgumentException("Failed to parse CreateBus command parameters.");
            }

            var bus = this.Factory.CreateBus(passengerCapacity, pricePerKilometer);
            this.Engine.Vehicles.Add(bus);

            return $"Vehicle with ID {Engine.Vehicles.Count - 1} was created.";
        }

    }
}
