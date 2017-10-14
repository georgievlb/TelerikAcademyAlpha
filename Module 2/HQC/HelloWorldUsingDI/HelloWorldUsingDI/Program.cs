using HelloWorldUsingIoC.Ninject;
using Ninject;

namespace HelloWorldUsingDI
{
    class Program
    {
        static void Main(string[] args)
        {
            //need to create kernel first to use the module
            //in the brackets we can specify which modules to use
            var kernel = new StandardKernel(new HelloWorldModule());

            //next thing is to ask for salutation

            var salutation = kernel.Get<Salutation>();

            salutation.Exclaim();
        }
    }
}
