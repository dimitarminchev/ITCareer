using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _618
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();

            // Input
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var cmd = Console.ReadLine().Split().ToArray();
                switch (cmd[0])
                {
                    case "Add":
                    {
                         list.Add(int.Parse(cmd[1]));
                         break;
                    }
                    case "Remove":
                    {
                         list.Remove(int.Parse(cmd[1]));
                         break;
                    }
                }
            }
            // Output
            Helper.WriteLine(list.Count);
            foreach (var item in list)
            Helper.Write($"{item} ");
        }
    }
}
