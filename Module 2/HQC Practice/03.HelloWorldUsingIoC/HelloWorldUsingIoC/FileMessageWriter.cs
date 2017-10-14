using System.IO;

namespace HelloWorldUsingIoC
{
    public class FileMessageWriter : IMessageWriter
    {
        public void Write(string text)
        {
            using (StreamWriter writer = new StreamWriter("DItest.txt"))
            {
                writer.Write(text);
            }
        }
    }
}
