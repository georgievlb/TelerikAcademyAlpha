using System;

class nestedCase
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int edinici = number % 10;
        int desetici = (number / 10)%10;
        int stotici = number / 100;
        //Console.WriteLine("stotici:{0,8}\n" + 
        //    "desetici:{1,7}\n" + " edinici:{2,7}\n", stotici, desetici, edinici);
        switch (stotici)
        {
            case 1:
                Console.Write("сто");
                break;
            case 2:
                Console.Write("двеста");
                break;
            case 3:
                Console.Write("триста");
                break;
            case 4:
                Console.Write("четиристотин");
                break;
            case 5:
                Console.Write("петстотин");
                break;
            case 6:
                Console.Write("шестотин");
                break;
            case 7:
                Console.Write("седемстотин");
                break;
            case 8:
                Console.Write("осемстотин");
                break;
            case 9:
                Console.Write("деветстотин");
                break;
            default:
                Console.WriteLine("Грешно въведено число.");
                break;
                //
                // for visibility, starting if to check the tents valie
                //
        }
                    switch (desetici)
                    {
                        case 1:
                            Console.Write(" и десет");
                            break;
                        case 2:
                            Console.Write(" двадесет");
                            break;
                        default:
                            break;
                    }
        switch (edinici)
        {

            case 1:
                Console.WriteLine(" и едно");
                break;
            default:
                break;
        }
                
        

    }
}


