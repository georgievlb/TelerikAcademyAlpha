using System;

namespace HelloWorldUsingIoC
{
    public class DataBaseWriter : IMessageWriter
    {
        public void Write(string text)
        {
            //Use Entity Framework..
            throw new NotImplementedException("Feature not added.");
        }
    }
}
