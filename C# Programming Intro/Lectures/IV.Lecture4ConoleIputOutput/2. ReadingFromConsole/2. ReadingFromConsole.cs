using System;

    class ReadingFromConsole
    {

    static void Main()
        {
        //ПРИМЕРИ ЗА Console.Read() - връща първия символ в опашката и връща 
        //като int променлива, която е неговият код. трябва да цъкнеш ентер или нищо няма да влезе

        //int i = Console.Read();
        //char ch = (char)i; // casts the int to char
        //Console.WriteLine("The code of '{0}' is {1}", ch, i);
        //i = Console.Read();
        //ch = (char)i;
        //Console.WriteLine("The code of '{0}' is {1}", ch, i);

        //// ПРИМЕРИ ЗА Console.Readkey()
        //ConsoleKeyInfo key = Console.ReadKey();
        //Console.WriteLine();
        //Console.WriteLine("Key name: " +key.Key);
        //Console.WriteLine("Key number: " + (int)key.Key);
        //Console.WriteLine("Special keys: [{0}] " , key.Modifiers);
        //Console.WriteLine("Character entered: " + key.KeyChar);

        //ПРИМЕРИ ЗА Console.ReadLine() - връща цял низ, без новия ред, приема цял текст, 
        //въведен в конзолата и цъкаш ентер
        Console.WriteLine("Please enter your first name: ");
        string firstName = Console.ReadLine();

        Console.WriteLine("Please enter your last name: ");
        string lastName = Console.ReadLine();

        Console.WriteLine("Hello, {0} {1}", firstName, lastName);
        //САМО ЗА ПРИПОМНЯНЕ - ТАКА СЕ ВЪВЕЖДА ЧИСЛО ОТ ПОТРЕБИТЕЛЯ
        //int pp;
        //pp = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine(pp);
        //Console.ReadLine() връща null ако е стигнала до края на файла
    }
    }