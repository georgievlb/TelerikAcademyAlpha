using Ninject;

namespace HelloWorldUsingIoC
{
    class Program
    {
        static void Main(string[] args)
        {
            //container DI
            HelloWorldModule 
            var kernel = new StandardKernel(new HelloWorldModule()); //our container with a configuration place in the module
            var salutation = kernel.Get<Salutation>();
            salutation.Exclaim();
        }
    }
}
