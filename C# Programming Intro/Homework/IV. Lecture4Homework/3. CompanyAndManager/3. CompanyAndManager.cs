using System;

class CompanyAndManager
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Green;

        Console.WriteLine("Enter company name: ");
        string companyName = Console.ReadLine();

        Console.WriteLine("Enter company address: ");
        string companyAddress = Console.ReadLine();

        Console.WriteLine("Enter company phone: ");
        string companyPhone = Console.ReadLine();

        Console.WriteLine("Enter company fax: ");
        string companyFax = Console.ReadLine();

        Console.WriteLine("Enter company site: ");
        string companySite = Console.ReadLine();

        Console.WriteLine("Enter the first name of the manager:");
        string managerFirstName = Console.ReadLine();

        Console.WriteLine("Enter the last name of the manager: ");
        string managerLastName = Console.ReadLine();

        Console.WriteLine("Enter the manager's phone: ");
        string managerPhone = Console.ReadLine();

        Console.WriteLine("Welcome to {0}!", companyName);
        Console.WriteLine("We are located at {0}.", companyAddress);
        Console.WriteLine("You can reach us by phone: {0}" + 
            " or fax: {0}.", companyPhone, companyFax);
        Console.WriteLine("Our website is {0}", companySite);
        Console.Write("Our manager's name is: {0} {1}. ", managerFirstName, managerLastName);
        Console.WriteLine("You can reach him at {0}", managerPhone);
        
    }
}

