using System;

namespace HelloWorldUsingIoC
{
    public class ConsoleMessageWriter : IMessageWriter
    {
        public void Write(string text)
        {
            Console.WriteLine(text);
        }
    }
}