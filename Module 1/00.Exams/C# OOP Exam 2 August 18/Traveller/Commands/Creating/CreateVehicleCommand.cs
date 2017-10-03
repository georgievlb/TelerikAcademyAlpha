using System;
using System.Collections.Generic;
using Traveller.Commands.Contracts;
using Traveller.Core.Contracts;

namespace Traveller.Commands.Creating
{
    public abstract class CreateVehicleCommand : ICommand
    {
        private readonly ITravellerFactory factory;
        private readonly IEngine engine;

        public CreateVehicleCommand(ITravellerFactory factory, IEngine engine)
        {
            this.factory = factory;
            this.engine = engine;
        }

        public ITravellerFactory Factory    //трябва да е protected
        {
            get { return this.factory; }
        }
        public IEngine Engine
        {
            get { return this.engine; }
        }


        public abstract string Execute(IList<string> parameters);
        
    }
}

            