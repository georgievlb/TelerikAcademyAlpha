using System;

namespace HelloWorldUsingIoC
{
    internal class Salutation
    {
        private readonly IMessageWriter writer;

        public Salutation(IMessageWriter writer)
        {
            this.writer = writer ?? throw new ArgumentNullException("Writer is null");
        }

        public void Exclaim()
        {
            this.writer.Write("Hello DI");
        }
    }
}