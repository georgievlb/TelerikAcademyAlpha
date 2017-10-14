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
            //if we need more than one binding we must name them
            this.Bind<IMessageWriter>()
                .To<ConsoleMessageWriter>()
                .Named("ConsoleWriter");

            this.Bind<IMessageWriter>()
                .To<FileMessageWriter>()
                .Named("FileWriter");

            this.Bind<IMessageWriter>()
                .To<DataBaseWriter>()
                .Named("DatabaseWriter");

            this.Bind<ISalutation>()
                .To<Salutation>()
                .WithConstructorArgument(this.Kernel.Get<IMessageWriter>("ConsoleWriter"));
        }
    }
}
