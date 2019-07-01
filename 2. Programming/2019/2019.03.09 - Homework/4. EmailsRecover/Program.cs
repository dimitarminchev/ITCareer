using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.EmailsRecover
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] commands = Console.ReadLine().Split(' ').ToArray();
                if (commands[0] == "stop") break;
                string emails = Console.ReadLine();
                string names = (string.Join(" ", commands));
                if (emails.Contains("bg") && commands[0] != "stop")
                    Console.WriteLine("{0} -> {1}", names, emails);
            }
        }
    }
}
