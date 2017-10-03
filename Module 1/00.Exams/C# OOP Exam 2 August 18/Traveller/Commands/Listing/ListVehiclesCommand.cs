using System;
using System.Collections.Generic;
using System.Text;
using Traveller.Commands.Contracts;
using Traveller.Core.Contracts;

namespace Traveller.Commands.Listing
{
    public class ListVehiclesCommand : ICommand
    {
        private readonly ITravellerFactory factory;
        private readonly IEngine engine;

        public ListVehiclesCommand(ITravellerFactory factory, IEngine engine)
        {
            this.factory = factory;
            this.engine = engine;
        }

        public string Execute(IList<string> parameters)
        {
            var vehicles = this.engine.Vehicles;
            if (vehicles.Count == 0)
            {
                return "There are no registered vehicles.";
            }
            //else
            //{
            //    StringBuilder builder = new StringBuilder();
            //    foreach (var vehicle in this.engine.Vehicles)
            //    {
            //        builder.Append(vehicle.ToString() + "####################" + "\n");
            //    }
            //    return builder.ToString();
            //}
            return string.Join(Environment.NewLine + "####################" + Environment.NewLine, vehicles);
        }
    }
}
