using System.Collections.Generic;

using OlympicGames.Core.Contracts;
using OlympicGames.Olympics.Contracts;
using OlympicGames.Utils;
using OlympicGames.Core.Commands.Abstracts;
using System;
using System.Linq;
using OlympicGames.Core.Factories;

namespace OlympicGames.Core.Commands
{
    public class CreateSprinterCommand : Command
    {
        // Consider using the dictionary
        private readonly IDictionary<string, double> records;
        private string command;

        public CreateSprinterCommand(IList<string> commandLine) 
            : base(commandLine)
        {
            commandLine.ValidateIfNull();
            this.command = string.Join(" ", commandLine);
            this.records = new Dictionary<string, double>();
        }

        public override string Execute()
        {
            string[] commandParameters = command
               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .ToArray();
            if (CommandParameters.Count < 4)
            {
                throw new ArgumentException(GlobalConstants.ParametersCountInvalid);
            }
            string firstName = commandParameters[0];
            string lastName = commandParameters[1];
            string country = commandParameters[2];
                        
            foreach (var record in commandParameters.Skip(3).ToArray())
            {
                var recordStats = record.Split('/').ToArray();
                records.Add(recordStats[0], double.Parse(recordStats[1]));
            }

            this.Committee.Olympians.Add(OlympicsFactory.Instance.CreateSprinter(firstName,
                lastName, country, records));
            
            return OlympicsFactory.Instance.CreateSprinter(firstName,
                lastName, country, records).ToString();
        }
    }
}
