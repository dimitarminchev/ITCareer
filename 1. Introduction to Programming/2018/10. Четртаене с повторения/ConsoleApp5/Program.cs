using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5. Квадратна рамка
            int n = int.Parse(Console.ReadLine());

            // Print the top row
            Console.Write("+");
            for (int i = 0; i < n - 2; i++) Console.Write(" -");
            Console.WriteLine(" +");
            // print the mid rows
            for (int row = 0; row < n - 2; row++)
            {
                Console.Write("|");
                for (int i = 0; i < n - 2; i++) Console.Write(" -");
                Console.WriteLine(" |");
            }
            // print the bottom row 
            Console.Write("+");
            for (int i = 0; i < n - 2; i++) Console.Write(" -");
            Console.WriteLine(" +");
        }
    }
}
