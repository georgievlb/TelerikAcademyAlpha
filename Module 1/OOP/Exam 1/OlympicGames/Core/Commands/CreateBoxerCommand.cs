using OlympicGames.Core.Commands.Abstracts;
using OlympicGames.Core.Factories;
using OlympicGames.Olympics.Contracts;
using OlympicGames.Olympics.Enums;
using OlympicGames.Olympics.Models;
using OlympicGames.Utils;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OlympicGames.Core.Commands
{
    public class CreateBoxerCommand : Command
    {
        private string command;

        //29 JULY: Inherit the base constructor
        //this.Factory.CreateBoxer(this.firstName, this.lastName, this.country, this.category, this.wins, this.losses);
        //this.CommandParameters = commandLine;
        public CreateBoxerCommand(IList<string> commandLine) 
            : base(commandLine)
        {
            commandLine.ValidateIfNull();
            this.command = string.Join(" ", commandLine);            
        }

        public override string Execute()
        {
            string[] commandParameters = command
               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .ToArray();
            if (CommandParameters.Count < 6)
            {
                throw new ArgumentException(GlobalConstants.ParametersCountInvalid);
            }
            string firstName = commandParameters[0];
            string lastName = commandParameters[1];
            string country = commandParameters[2];
            string category = commandParameters[3];
            int wins = int.Parse(commandParameters[4]);
            int losses = int.Parse(commandParameters[5]);

            this.Committee.Olympians.Add(OlympicsFactory.Instance.CreateBoxer(firstName, 
                lastName, country, category, wins, losses));
            

            return OlympicsFactory.Instance.CreateBoxer(firstName, 
                lastName, country, category, wins, losses).ToString();

            //return string.Format
            //(@"Created Boxer

            //BOXER: {0} {1} from {2}
            //Category: {3}
            //Wins: {4}
            //Losses: {5}",
            //firstName,
            //lastName,
            //country,
            //category,
            //wins,
            //losses);
        }
    }
}





