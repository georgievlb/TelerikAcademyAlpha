using System;

class Program
{
    static void Main(string[] args)
    {
        string mainString = Console.ReadLine();
        string[] upcases = new string[] { "<a " };
        string[] stringModified = mainString.Split(upcases, StringSplitOptions.None);
        
        string endOfText = "</a";

        //print the splitted string
        for (int i = 0; i < stringModified.Length; i++)
        {
            Console.WriteLine(stringModified[i]);
        }


        for (int i = 0; i < stringModified.Length; i++)
        {
            //find the indexes of the end of the opening a href tag >"
            int startOfLink = (stringModified[i].IndexOf("\">"));
            if (startOfLink > -1)
            {
                Console.WriteLine(stringModified[i].Substring(0, startOfLink));
                //Console.WriteLine(startOfLink);
            }


            //find the indexes of the closing a href tag </a
            //if (stringModified[i].IndexOf("</a") > -1 )
            //{
            //    int hyperlinkEnd = stringModified[i].IndexOf("</");
            //    string hyperlink = stringModified[i].Substring(0, hyperlinkEnd);
            //    Console.WriteLine(hyperlinkEnd);
            //}
        }
    }
}
