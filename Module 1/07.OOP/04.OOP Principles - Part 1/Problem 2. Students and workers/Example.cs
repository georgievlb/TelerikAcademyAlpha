//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOPPrinciplesPart1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            char[] chars = new char[] { '.', '-', '+', '^', '°', '*' };
//            for (int i = 0; ; i++)
//            {
//                if (i != 0)
//                {
//                    // Delete the previous char by setting it to a space
//                    Console.SetCursorPosition(6 - (i - 1) % 6 - 1, Console.CursorTop);
//                    Console.Write(" ");
//                }

//                // Write the new char
//                Console.SetCursorPosition(6 - i % 6 - 1, Console.CursorTop);
//                Console.Write(chars[i % 6]);

//                System.Threading.Thread.Sleep(100);
//            }
//        }
//    }
//}
