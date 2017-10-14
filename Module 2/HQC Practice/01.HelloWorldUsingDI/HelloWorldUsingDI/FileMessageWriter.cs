using System.IO;

namespace HelloWorldUsingDI
{
    internal class FileMessageWriter : IMessageWriter
    {
        public void Write(string message)
        {
            using (StreamWriter writer = new StreamWriter("text.txt"))
            {
                writer.WriteLine(message);
            }
        }
    }
}