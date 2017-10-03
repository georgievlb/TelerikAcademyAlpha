using Academy.Models.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models.Academy.Abstractions
{
    public abstract class AcademyPerson: IUser
    {
        private string username;

        public AcademyPerson(string username)
        {
            this.Username = username;
        }

        public string Username
        {
            get { return this.username; }
            set
            {
                Validator.ValidateIfNullOrEmpty(value, "Username cannot be null or empty!");
                Validator.ValidateMinAndMaxLength(value,
                    Constants.MinUsernameLength,
                    Constants.MaxUsernameLength,
                    "User's username should be between 3 and 16 symbols long!");

                this.username = value;
            }
        }

        
    }
}
