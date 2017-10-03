using System.Collections.Generic;
using System.Linq;
using System.Text;

using OlympicGames.Core.Commands.Abstracts;
using OlympicGames.Core.Contracts;
using OlympicGames.Utils;
using System;

namespace OlympicGames.Core.Commands
{
    public class ListOlympiansCommand : Command//, ICommand // DO I NEED ICOMMAND
    {
        private string key;
        private string order;
        private string command;
        private IDictionary<string, double> records = new Dictionary<string, double>();

        public ListOlympiansCommand(IList<string> commandParameters)
            : base(commandParameters)
        {
            commandParameters.ValidateIfNull();
            this.command = string.Join(" ", commandParameters);
            if (commandParameters.Count > 1)
            {
                this.key = commandParameters[0];
                this.order = commandParameters[1];
            }
        }
        
        // Use it. It works!
        public override string Execute()
        {
            var commandParameters = command.Split(' ').ToArray();
            StringBuilder printCommand = new StringBuilder();
            var sortedCommittee = this.Committee.Olympians.ToList();

            commandParameters.ValidateIfNull();
            
            if (Committee.Olympians.Count == 0) //no olympians error
            {
                Console.Write("{0}", GlobalConstants.NoOlympiansAdded);
            }
            //listolympians
            //implement default listolympians - firstname /asc
            //else if (commandParameters.Length == 0)
            //{
            //    sortedCommittee = this.Committee.Olympians.OrderBy(x => x.FirstName).ToList();
            //    printCommand.AppendLine("Sorted by [key: firstname] in [order: asc]");
            //}
            //listolympians firstname
            else if (commandParameters[0] == "firstname")
            {
                sortedCommittee = this.Committee.Olympians.OrderBy(x => x.FirstName).ToList();
                printCommand.AppendLine("Sorted by [key: firstname] in [order: asc]");
            }
            //listolympians lastname
            else if (commandParameters[0] == "lastname")
            {
                sortedCommittee = this.Committee.Olympians.OrderBy(x => x.LastName).ToList();
                printCommand.AppendLine("Sorted by [key: lastname] in [order: asc]");
            }
            //listolympians country
            //else if (commandParameters[0] == "country")
            //{
            //    sortedCommittee = this.Committee.Olympians.OrderBy(x => x.Country).ToList();
            //    printCommand.AppendLine("Sorted by [key: country] in [order: asc]");
            //}
            //sort in descending order
            else if (this.order.ToLower().Trim() == "desc")
            {
                sortedCommittee = this.Committee.Olympians.OrderByDescending(x =>
                {
                    return x.GetType().GetProperties().FirstOrDefault(y => y.Name.ToLower() == this.key.ToLower()).GetValue(x, null);
                }).ToList();
            }
            //sort in ascending order
            else
            {
                sortedCommittee = this.Committee.Olympians.OrderBy(x =>
                {
                    return x.GetType().GetProperties().FirstOrDefault(y => y.Name.ToLower() == this.key.ToLower()).GetValue(x, null);
                }).ToList();
            }

            foreach (var olympian in sortedCommittee)
            {
                printCommand.AppendLine(olympian.ToString());
            }

            return printCommand.ToString();
        }
    }
}


//else if (commandParameters.Length == 1 && Committee.Olympians.Count > 0)
//{
//    sortedCommittee = sortedCommittee.OrderBy(x => x.FirstName).ToList();
//    foreach (var olympian in sortedCommittee)
//    {
//        printCommand.AppendLine(olympian.ToString());
//    }
//}

//Validator.ValidateIfNull(command);

//if (sortedCommittee.Count == 0)

//{

//}

//if (commandParameters.Length == 0)

//{
//    sortedCommittee = sortedCommittee.OrderBy(x => x.FirstName).ToList();
//}