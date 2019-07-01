using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.ArrayProcessing
{
    class Program
    {
        // 09. Обработка на масив
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split().ToArray();
            int n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                var cmd = Console.ReadLine().Split().ToArray();
                switch (cmd[0])
                {
                    case "Reverse": array = array.Reverse().ToArray(); break; 
                    case "Distinct": array = array.Distinct().ToArray(); break;
                    case "Replace": array[int.Parse(cmd[1])] = cmd[2]; break;
                }
                n--;
            }
            Console.WriteLine(string.Join(", ", array));
        }
    }
}
