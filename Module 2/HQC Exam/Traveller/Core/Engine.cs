using System;
using System.Collections.Generic;
using System.Text;
using Traveller.Commands.Contracts;
using Traveller.Core.Contracts;
using Traveller.Core.Providers;
using Traveller.Models;
using Traveller.Models.Abstractions;
using Traveller.Models.Vehicles.Abstractions;

namespace Traveller.Core
{
    public class Engine
    {
        private const string TerminationCommand = "Exit";
        private const string NullProvidersExceptionMessage = "cannot be null.";
                
        private StringBuilder Builder = new StringBuilder();

        private readonly IReader reader;
        private readonly IWriter writer;
        private readonly IDatabase database;
        private readonly ICommandParser commandParser;

        public Engine(IReader reader, IWriter writer, IDatabase database, ICommandParser parser)
        {
            this.reader = reader;
            this.writer = writer;
            this.database = database;
            this.commandParser = parser;
        }
        
        public void Start()
        {
            while (true)
            {
                try
                {
                    var commandAsString = this.reader.ReadLine();

                    if (commandAsString.ToLower() == TerminationCommand.ToLower())
                    {
                        this.writer.Write(this.Builder.ToString());
                        break;
                    }

                    string result = this.commandParser.parseCommand(commandAsString);
                    this.database.CommandResult.Add(result);
                }
                catch (Exception ex)
                {
                    this.Builder.AppendLine(ex.Message);
                }
            }
        }

        //private void ProcessCommand(string commandAsString)
        //{
        //    if (string.IsNullOrWhiteSpace(commandAsString))
        //    {
        //        throw new ArgumentNullException("Command cannot be null or empty.");
        //    }

        //    var parser = new CommandParser();
        //    var command = parser.ParseCommand(commandAsString);
        //    var parameters = parser.ParseParameters(commandAsString);

        //    var executionResult = command.Execute(parameters);
        //    this.Builder.AppendLine(executionResult);
        //}
    }
}
