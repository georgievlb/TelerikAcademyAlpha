using System;
using System.Collections.Generic;
using Traveller.Commands.Contracts;
using Traveller.Core;
using Traveller.Core.Contracts;
using Traveller.Core.Factories;
using Traveller.Models;
using Traveller.Models.Abstractions;

namespace Traveller.Commands.Creating
{
    public class CreateTicketCommand : CreateObjectCommand, ICommand
    {
        public CreateTicketCommand(ITravellerFactory factory, IDatabase database)
            :base(factory, database)
        {

        }

        public override string Execute(IList<string> parameters)
        {
            IJourney journey;
            decimal administrativeCosts;

            try
            {
                journey = this.Database.Journeys[int.Parse(parameters[0])];
                administrativeCosts = decimal.Parse(parameters[1]);
            }
            catch
            {
                throw new ArgumentException("Failed to parse CreateTicket command parameters.");
            }

            var ticket = TravellerFactory.Instance.CreateTicket(journey, administrativeCosts);
            this.Database.Tickets.Add(ticket);

            return $"Ticket with ID {this.Database.Tickets.Count - 1} was created.";
        }
    }
}
