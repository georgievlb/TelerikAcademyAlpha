using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveller.Commands.Contracts;
using Traveller.Core.Contracts;

namespace Traveller.Commands.Listing
{
    public abstract class ListObjectCommand : ICommand
    {
        public IDatabase Database { get; }
        public ListObjectCommand(IDatabase database)
        {
            this.Database = database;
        }

        public abstract string Execute(IList<string> parameters);
       
    }
}
