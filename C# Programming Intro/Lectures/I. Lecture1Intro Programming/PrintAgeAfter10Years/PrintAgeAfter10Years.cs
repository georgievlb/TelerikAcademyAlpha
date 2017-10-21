using System;

class PrintAgeAfter10Years
{
    static void Main()
    {
        Console.WriteLine("Enter your age: ");
        int age;
        //zastho go chete kato string??
        //trqbva mu da se convertira v int predi da se prochete ot konzolata
        //eto dva varianta
        //age = Convert.ToInt32(Console.ReadLine());
        age = Int32.Parse(Console.ReadLine());
        Console.WriteLine("You are {0} years old. ", age);





        //Console.Write("In 10 years you will be: ");
        //Console.Write(age+10);
        //Console.WriteLine(" years old.");
    }
}
