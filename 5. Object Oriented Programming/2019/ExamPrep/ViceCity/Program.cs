using System;
using ViceCity.Core;
using ViceCity.Core.Contracts;

namespace ViceCity
{
    class Program
    {
        IEngine engine;

        static void Main(string[] args)
        {
            IEngine engine = new Engine();
            engine.Run();
        }
    }
}
