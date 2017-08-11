using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympicGames.Core.Commands.Abstracts
{
    public abstract class CreateOlympianCommand : Command
    {
        public CreateOlympianCommand(IList<string> commandLine) : base(commandLine)
        {
        }
    }
}
