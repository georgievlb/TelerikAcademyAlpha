using System;

namespace HelloWorldUsingDI
{
    public class Salutation
    {
        private readonly IMessageWriter writer;     //readonly to prevent changes; doesn't have a property because we don't need it to change

        
        public Salutation(IMessageWriter writer)    //salutation doesn't care where the text will be printed
        {
            //the purpose of this validation is to fail fast
            //new syntax
            this.writer = writer ?? throw new ArgumentNullException("Writer is null");

            //old syntax
            //if (writer == null)
            //{
            //    throw new ArgumentNullException("Writer");
            //}
        }

        public void Exclaim()
        {
            this.writer.Write("Hello DI!");
        }

    }
}