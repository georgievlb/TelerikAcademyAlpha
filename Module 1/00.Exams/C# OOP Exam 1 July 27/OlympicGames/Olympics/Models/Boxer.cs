using System;
using OlympicGames.Olympics.Contracts;
using OlympicGames.Olympics.Enums;
using OlympicGames.Utils;

namespace OlympicGames.Olympics.Models
{
    public class Boxer : Olympian, IBoxer
    {
        private BoxingCategory category;
        private int wins;
        private int losses;
        //SEE IF THE FACTORY RECOGNIZES THE BOXINGCATEGORY ENUM, IF NOT, MAKE IT A STRING AND VALIDATE IT IN THE PROPERTY
        public Boxer(string firstName, string lastName, string country, BoxingCategory category, int wins, int losses) 
            : base(firstName, lastName, country)
        {
            this.Category = category;
            this.Wins = wins;
            this.Losses = losses;
        }

        public BoxingCategory Category
        {
            get
            {
                return this.category;
            }

            private set
            {
                Validator.ValidateIfNull(value, "Category cannot be null!");    //NOT SURE IF I NEED THIS!
                //BoxingCategory finalCategory = new BoxingCategory();
                //Enum.TryParse(category, out finalCategory);
                //return new Boxer(firstName, lastName, country, finalCategory, wins, losses);
                category = value;
            }
        }

        public int Losses
        {
            get
            {
                return this.losses;
            }

            private set
            {
                Validator.ValidateIfNull(value, "Losses cannot be null!");
                Validator.ValidateMinAndMaxNumber(value,
                    Constants.MinWinsOrLossesNumber,
                    Constants.MaxWinsOrLossesNumber,
                    string.Format("Losses must be between {0} and {1}!",
                    Constants.MinWinsOrLossesNumber,
                    Constants.MaxWinsOrLossesNumber));

                this.losses = value;
            }
        }

        public int Wins
        {
            get
            {
                return this.wins;
            }

            private set
            {
                Validator.ValidateIfNull(value, "Wins cannot be null!");    //DO I EVEN NEED THIS
                Validator.ValidateMinAndMaxNumber(value, 
                    Constants.MinWinsOrLossesNumber,
                    Constants.MaxWinsOrLossesNumber,
                    string.Format("Wins must be between {0} and {1}!", 
                    Constants.MinWinsOrLossesNumber, 
                    Constants.MaxWinsOrLossesNumber));

                this.wins = value;
            }
        }
        //29 JULY
        public override string ToString()
        {
            return string.Format("Created Boxer\nBOXER: {0} {1} from {2}\nCategory: {3}\nWins: {4}\nLosses: {5}\n",
           this.FirstName,
           this.LastName,
           this.Country,
           this.Category,
           this.Wins,
           this.Losses); 
        }
    }
}


////
//return string.Format("First name: {0} Last name: {1} Country: {2} Category: {3} Wins: {4} Losses: {5}",
//            this.FirstName,
//            this.LastName,
//            this.Country,
//            this.Category,
//            this.Wins,
//            this.Losses);
//// [firstname] [lastname] [country] [category] [wins] [losses]
////