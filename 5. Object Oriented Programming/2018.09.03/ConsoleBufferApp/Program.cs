using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBufferApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Буферирана конзола
            BufferedConsole buf = new BufferedConsole();
            while (true) buf.Write(Console.ReadLine());
        }
    }
}
