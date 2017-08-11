using System;
using System.Collections.Generic;
using Academy.Commands.Contracts;
using Academy.Core.Contracts;
using System.Text;
using System.Linq;
using Academy.Models;

namespace Academy.Commands.Listing
{
    public class ListUsersCommand : ICommand
    {
        private readonly IAcademyFactory factory;
        private readonly IEngine engine;

        public ListUsersCommand(IAcademyFactory factory, IEngine engine)
        {
            this.factory = factory;
            this.engine = engine;
        }

        public string Execute(IList<string> parameters)
        {
            var users = this.engine.Trainers.Select(x => (IUser)x).ToList();
            users.AddRange(this.engine.Students);
            if (engine.Trainers.Count == 0 && engine.Students.Count == 0)
            {
                throw new ArgumentException("There are no registered users!");
            }

            return string.Join("\n", users);
        }
    }
}
