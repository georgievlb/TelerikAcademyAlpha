using HelloWorldUsingDI;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldUsingIoC.Ninject
{
    public class HelloWorldModule : NinjectModule //inherit this to create Ninject module
    {
        public override void Load()
        {
            //this is where the magic happens;

            //config container here
            this.Bind<IMessageWriter>().To<ConsoleMessageWriter>();
            //give me a salutation
            this.Bind<ISalutation>().To<Salutation>();
        }
    }
}
