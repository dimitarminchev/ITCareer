using System;
using ViceCity.Core;
using ViceCity.Core.Contracts;

namespace ViceCity
{
    public class StartUp
    {
        IEngine engine;

        static void Main(string[] args)
        {
            IEngine engine = new Engine();
            engine.Run();
        }
    }
}
