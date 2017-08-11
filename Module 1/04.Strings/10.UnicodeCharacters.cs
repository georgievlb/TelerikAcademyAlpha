using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string text = Console.ReadLine();
        StringBuilder builder = new StringBuilder();
                
        foreach (char letter in text)
        {
            builder.Append(string.Format("\\u{0:X4}", (ushort)letter));
        }
        Console.WriteLine(builder.ToString());
    }
}
