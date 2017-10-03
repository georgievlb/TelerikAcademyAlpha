using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveller.Commands.Contracts
{
    public interface IParser
    {
        ICommand ParseCommand(string command);
        IList<string> ParseParameters(string command);
    }
}
