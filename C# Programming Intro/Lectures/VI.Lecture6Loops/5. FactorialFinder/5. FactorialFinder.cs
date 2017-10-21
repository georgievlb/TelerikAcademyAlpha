using System;
using System.Numerics; // za BigInteger
using System.Windows.Forms; // za pop up
class Program
{
    static void Main()
    {
        MessageBox.Show("хай лол"); 
        string consoleInputLine = Console.ReadLine();
        int n = Convert.ToInt32(consoleInputLine);

        Console.Write("n! = ");

        // "decimal" is the biggest integer type
        BigInteger factorial = 1;

        //Perform an infinite loop
        while (true)
        {
            Console.Write(n);
            if (n == 1)
            {
                break;
            }
            Console.Write(" * ");
            factorial *= n;
            n--;
        }
        Console.WriteLine(" * {0}", factorial);
       
    }
}
 