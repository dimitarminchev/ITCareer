using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _512
{
    class Program
    {
        // Автор: Христо Широв
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            Console.WriteLine(Search.IndexOf<int>(arr, 3));
        }
    }
}
