﻿using OlympicGames.Core.Contracts;
using OlympicGames.Utils;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OlympicGames.Core.Commands
{
    public class ListOlympiansCommand : ICommand
    {
        private readonly IOlympicCommittee committee;

        private string key;
        private string order;

        public ListOlympiansCommand(IOlympicCommittee committee)
        {
            this.committee = committee;
        }

        public string Execute(IList<string> commandLine)
        {
            if (commandLine == null || commandLine.Count == 0)
            {
                this.key = "firstname";
                this.order = "asc";
            }
            else if (commandLine.Count == 1)
            {
                this.key = commandLine[0];
                this.order = "asc";
            }
            else
            {
                if (commandLine[1].ToLower() != "asc" && commandLine[1].ToLower() != "desc")
                {
                    this.order = "asc";
                }
                else
                {
                    this.order = commandLine[1];
                }
                this.key = commandLine[0];
            }

            var stringBuilder = new StringBuilder();
            var sorted = this.committee.Olympians.ToList();

            if (sorted.Count == 0)
            {
                stringBuilder.AppendLine(GlobalConstants.NoOlympiansAdded);
                return stringBuilder.ToString();
            }

            stringBuilder.AppendLine(string.Format(GlobalConstants.SortingTitle, this.key, this.order));

            if (this.order.ToLower().Trim() == "desc")
            {
                sorted = this.committee.Olympians.OrderByDescending(x =>
                {
                    return x.GetType().GetProperties().FirstOrDefault(y => y.Name.ToLower() == this.key.ToLower()).GetValue(x, null);
                }).ToList();
            }
            else
            {
                sorted = this.committee.Olympians.OrderBy(x =>
                {
                    return x.GetType().GetProperties().FirstOrDefault(y => y.Name.ToLower() == this.key.ToLower()).GetValue(x, null);
                }).ToList();
            }

            foreach (var item in sorted)
            {
                stringBuilder.AppendLine(item.ToString());
            }

            return stringBuilder.ToString();
        }
    }
}
