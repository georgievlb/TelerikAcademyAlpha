using System;

namespace SwitchCase
{
    class SwitchCase
    {
        // this is how an enum class is declared
        public enum Weekday
        {   Monday,         //0
            Tuesday,        //1
            Wednesday,      //2
            Thursday,
            Friday,
            Saturday,
            Sunday
        };
        //this is how a regular enum is declared - probably a bad practice
        enum Animals { Pig };
        static void Main()
        {
            
            //this is how an enum class is accessed
            Weekday day = Weekday.Monday;
            //this is how a regular enum is accessed - probably a bad practice
            Animals animal = Animals.Pig;
            switch (day)
                {
                case Weekday.Monday:
                    Console.WriteLine("The day is Monday.");
                    break;
                default:
                    Console.WriteLine("Unrecognized day.");
                    break;
                }
            Console.WriteLine(day);
            Console.WriteLine(animal);
        }
    }
}
