using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StorageMaster.Storage;

namespace StorageMaster
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var reader = new ConsoleReader();
            var writer = new ConsoleWriter();
            var engine = new Engine(reader, writer);
            engine.Run();
        }
    }
}
