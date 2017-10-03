using System;

namespace Traveller.Utils
{
    
    public static class Validator
    {
        public static void CheckIfNull(object obj, string message = null)
        {
            if (obj == null)
            {
                throw new NullReferenceException(message);
            }
        }

        public static void CheckIfStringIsNullOrEmpty(string text, string message = null)
        {
            if (string.IsNullOrEmpty(text))
            {
                throw new NullReferenceException(message);
            }
        }

        public static void CheckIfStringLengthIsValid(string text, int min, int max, string message = null)
        {
            if (text.Length < min || text.Length > max)
            {
                throw new ArgumentOutOfRangeException(message);
            }
        }

        public static void CheckIfNumberValueIsValid(int number, int min, int max, string message = null)
        {
            if (number < min || number > max)
            {
                throw new ArgumentOutOfRangeException(message);
            }
        }

        public static void PriceCheck(decimal price, decimal min, decimal max, string message = null)
        {
            if (price < min || price > max)
            {
                throw new ArgumentOutOfRangeException(message);
            }
        }
    }
}
