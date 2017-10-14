using HelloWorldUsingIoC.Ninject;
using Ninject;
using System;

namespace HelloWorldUsingIoC
{
    class Program
    {
        static void Main(string[] args)
        {
            //container DI
            var kernel = new StandardKernel(new HelloWorldModule()); //our container with a configuration place in the module
            var salutation = kernel.Get<ISalutation>();
            salutation.Exclaim();

            var useFileWriter = kernel.Get<IMessageWriter>("FileWriter");
            useFileWriter.Write("I am the file writer.");
        }
    }
}
