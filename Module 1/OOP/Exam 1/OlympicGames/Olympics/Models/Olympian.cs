using OlympicGames.Olympics.Contracts;
using OlympicGames.Olympics.Enums;
using OlympicGames.Utils;

namespace OlympicGames.Olympics.Models
{
    public abstract class Olympian : IOlympian
    {

        private string firstName;
        private string lastName;
        private string country;


        public Olympian(string firstName, string lastName, string country)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Country = country;        
        }

        

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                Validator.ValidateIfNull(value, "First name must not be null!");
                Validator.ValidateMinAndMaxLength(value,
                    Constants.MinNameLength,
                    Constants.MaxNameLength,
                    string.Format("First name must be between {0} and {1} characters long!", 
                    Constants.MinNameLength, 
                    Constants.MaxNameLength));

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                Validator.ValidateIfNull(value, "Last name must not be null!");
                Validator.ValidateMinAndMaxLength(value,
                    Constants.MinNameLength,
                    Constants.MaxNameLength,
                    string.Format("Last name must be between {0} and {1} characters long!",
                    Constants.MinNameLength,
                    Constants.MaxNameLength));

                this.lastName = value;
            }
        }

        public string Country
        {
            get
            {
                return this.country;
            }
            private set
            {
                Validator.ValidateIfNull(value, "Country cannot be null!");
                Validator.ValidateMinAndMaxLength(value,
                    Constants.MinCountryLength,
                    Constants.MaxCountryLength,
                    string.Format("Country must be between {0} and {1} characters long!",
                    Constants.MinCountryLength,
                    Constants.MaxCountryLength));

                this.country = value;
            }
        }
    }
}
