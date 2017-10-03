﻿using System;
using System.Collections.Generic;
using Traveller.Commands.Contracts;
using Traveller.Core.Contracts;
using Traveller.Models.Contracts;
using Traveller.Models.Vehicles.Contracts;

namespace Traveller.Commands.Creating
{
    public class CreateTicketCommand : ICommand
    {
        private readonly ITravellerFactory factory;
        private readonly IEngine engine;

        public CreateTicketCommand(ITravellerFactory factory, IEngine engine)
        {
            this.factory = factory;
            this.engine = engine;
        }

        public string Execute(IList<string> parameters)
        {
            decimal administrativeCosts;
            IJourney journey;

            try
            {
                journey = this.engine.Journeys[int.Parse(parameters[0])];
                administrativeCosts = decimal.Parse(parameters[1]);
            }
            catch
            {
                throw new ArgumentException("Failed to parse CreateTicket command parameters.");
            }

            var ticket = this.factory.CreateTicket(journey, administrativeCosts);
            this.engine.Tickets.Add(ticket);

            return $"Ticket with ID {engine.Tickets.Count - 1} was created.";
        }

    }
}
