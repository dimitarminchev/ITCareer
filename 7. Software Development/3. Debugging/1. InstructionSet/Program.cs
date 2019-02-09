using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.InstructionSet
{
    public class Program
    {
        public static void Main()
        {
            var instruction = new Instructions();
            string code = Console.ReadLine();
            while(code != "END")
            {
                Console.WriteLine(instruction.Execute(code));
                code = Console.ReadLine();
            }
        }
    }
}
