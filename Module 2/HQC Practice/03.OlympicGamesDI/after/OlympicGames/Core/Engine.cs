using System;

using OlympicGames.Core.Contracts;
using OlympicGames.Core.Factories;
using OlympicGames.Core.Providers;
using Bytes2you.Validation;

namespace OlympicGames.Core
{
    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;
        private readonly ICommandParser parser;
        private readonly ICommandProcessor commandProcessor;

        private const string Delimiter = "####################";

        public Engine(
            IReader reader, 
            IWriter writer, 
            ICommandParser parser, 
            ICommandProcessor commandProcessor)
        {
            Guard.WhenArgument(reader, "reader").IsNull().Throw();
            Guard.WhenArgument(writer, "writer").IsNull().Throw();
            Guard.WhenArgument(parser, "parser").IsNull().Throw();
            Guard.WhenArgument(commandProcessor, "commandProcessor").IsNull().Throw();


            this.reader = reader;
            this.writer = writer;
            this.parser = parser;
            this.commandProcessor = commandProcessor;
        }

        public void Run()
        {
            string commandLine = null;

            while ((commandLine = this.reader.Read()) != "end")
            {
                try
                {
                    var command = this.parser.ParseCommand(commandLine);
                    if (command != null)
                    {
                        //this.commandProcessor.Add(command);
                        this.commandProcessor.ProcessSingleCommand(command, commandLine);
                        this.writer.Write(Delimiter);
                    }
                }
                catch (Exception ex)
                {
                    while (ex.InnerException != null)
                    {
                        ex = ex.InnerException;
                    }

                    this.writer.Write($"ERROR: {ex.Message}");
                }
            }
        }
    }
}
