using Ninject;
using OlympicGames.Core;
using OlympicGames.Core.Contracts;
using OlympicGames.Ninject;

namespace OlympicGames
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var kernel = new StandardKernel(new OlympiansModule());
            var engine = kernel.Get<IEngine>();
            engine.Run();

        }
    }
}
