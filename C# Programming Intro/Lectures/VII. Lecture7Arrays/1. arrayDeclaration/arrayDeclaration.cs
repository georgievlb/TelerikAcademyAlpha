// v .net masiva e class i si znae duljinata

using System;

class arrayDeclaration
{
        static void Main()
    {
        //delcaring array of integers;
        int[] myIntArray; // = null няма стойност А НЕ ЧЕ Е ПРАЗЕН!
        //null - адрес нула в паметта - специален адрес
        //declaring array of strings:
        string[] myStringArray;
        // ot veski tip danni moje da si napravim masiv
        // sled kato se deklarira masiva sledva
        //zadelqne /alokirane/suzdavane (на памет)
        //zadelq se taka :
        myIntArray = new int[5]; //zadelq 5 kletki vsqka ot tip int
                                 //zadelq se i edna kletka v koqto stoi stoinostta length
        int arrayLength = myIntArray.Length;
        Console.WriteLine("The array containts {0} elements", arrayLength);
        //в С# не можем да излезем от дължината на масива


        //операторът new служи за заделяне на нов обект
        //заделянето на нов обект е свързано със заделяне на динамична памет
        //една програма има две области в паметта. Първата е стек - съдържа всички локални промелниви
        //    едната област от паметта се нарича стек; той съдържа всички
        //    локални променливи. в стека стои един адрес - номера на клетката в паметта
        //e.g. y = 7 стойността на у е в стека
        //всички стрингове + тяхната дължина се пазят в heap
        //Елементите на масивите винаги се съхраняват в динамичната памет (в т. нар. heap).
        //адресът на стринга се пази в стека
        //в стека стои един адрес
        //масивът като масив е на 64 битова машина 8 байтова стойност,
        //на 32 битова машина е 4 бита,
        //които казват кой е адресът в паметта в който стои този обект
        //стойността се пази в heap. това за всички обекти и типове данни от референтен тип е
        //свързано с динамичната памет. стека държи малки данни някакви единични числа, адреси на обекти
        //стойностите на всички обекти се държат в heap-a - динамична памет, управлявана от garbage collectora (нарича се managed heap)
        //нарича се стек, защото като заделим променливи другите отиват след тях.
        //всеки един обект в динамичната памет си знае типа

        //инициализиране на масив

        //int[] myIntArray = {1, 2, 3, 4, 5 }; // същото като new int[5]
        string[] daysOfWeek = {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"
        };
        //достъпът до елементите на масива е пряк

    }

}

