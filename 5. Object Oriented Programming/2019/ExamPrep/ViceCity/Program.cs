using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
