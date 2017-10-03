using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveller.Commands.Contracts;
using Traveller.Core.Contracts;

namespace Traveller.Commands.Creating
{
    public class CreateAirplaneCommand : CreateVehicleCommand, ICommand
    {
        //private readonly ITravellerFactory factory;
        //private readonly IEngine engine;

        public CreateAirplaneCommand(ITravellerFactory factory, IEngine engine) 
            : base(factory, engine)
        {
        }

        //public CreateAirplaneCommand(ITravellerFactory factory, IEngine engine) 
        //{
        //    this.factory = factory;
        //    this.engine = engine;
        //}

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

            var airplane = this.Factory.CreateAirplane(passengerCapacity, pricePerKilometer, hasFreeFood);
            this.Engine.Vehicles.Add(airplane);

            return $"Vehicle with ID {Engine.Vehicles.Count - 1} was created.";
        }
    }
}
