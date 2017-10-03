﻿using System;
using System.Collections.Generic;
using Traveller.Commands.Contracts;
using Traveller.Core;
using Traveller.Core.Contracts;
using Traveller.Core.Factories;

namespace Traveller.Commands.Creating
{
    public class CreateTrainCommand : CreateObjectCommand, ICommand
    {
        public CreateTrainCommand(ITravellerFactory factory, IDatabase database)
            :base(factory, database)
        {

        }


        public override string Execute(IList<string> parameters)
        {
            int passengerCapacity;
            decimal pricePerKilometer;
            int cartsCount;

            try
            {
                passengerCapacity = int.Parse(parameters[0]);
                pricePerKilometer = decimal.Parse(parameters[1]);
                cartsCount = int.Parse(parameters[2]);
            }
            catch
            {
                throw new ArgumentException("Failed to parse CreateTrain command parameters.");
            }

            var train = TravellerFactory.Instance.CreateTrain(passengerCapacity, pricePerKilometer, cartsCount);
            this.Database.Vehicles.Add(train);

            return $"Vehicle with ID {this.Database.Vehicles.Count - 1} was created.";
        }
    }
}
