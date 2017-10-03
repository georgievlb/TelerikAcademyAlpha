using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveller.Commands.Contracts;
using Traveller.Core.Contracts;

namespace Traveller.Commands.Creating
{
    public abstract class CreateObjectCommand : ICommand
    {
        public ITravellerFactory Factory { get; }
        public IDatabase Database { get; }

        public CreateObjectCommand(ITravellerFactory factory, IDatabase database)
        {
            this.Factory = factory;
            this.Database = database;
        }

        public abstract string Execute(IList<string> parameters);
        
    }
}
