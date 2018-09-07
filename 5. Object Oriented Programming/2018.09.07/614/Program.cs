using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _614
{
    class Program
    {
        static void Main(string[] args)
        {
            ListyIterator<string> list = new ListyIterator<string>();
            var line = Console.ReadLine().Split().ToArray();
            while (line[0] != "END")
            {
                switch (line[0])
                {
                    case "Create":
                        list.Create(line.Skip(1).ToArray());
                        break;
                    case "HasNext":
                        Helper.WriteLine(list.HasNext());
                        break;
                    case "Move":
                        Helper.WriteLine(list.Move());
                        break;
                    case "Print": 
                        Helper.WriteLine(list.Print());
                        break;
                    case "PrintAll":
                        Helper.WriteLine(list.PrintAll());
                        break;
                }
                line = Console.ReadLine().Split().ToArray();
            }
        }
    }
}
