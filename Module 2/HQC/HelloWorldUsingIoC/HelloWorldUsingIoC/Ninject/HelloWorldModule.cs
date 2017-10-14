using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldUsingIoC.Ninject
{
    public class HelloWorldModule : NinjectModule
    {
        public override void Load()
        {

            this.Bind<IMessageWriter>().To<ConsoleMessageWriter>();
            this.Bind<ISalutation>().To<Salutation>();
        }
    }
}
