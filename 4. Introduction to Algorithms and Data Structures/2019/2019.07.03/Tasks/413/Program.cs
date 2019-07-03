using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _413
{
    class Program
    {
        // Автор: Христо Широв
        static void Main(string[] args)
        {
            int[] arr = { 95, 98, 103, 109, 48, 92, 25, 106, 160 };

            Console.WriteLine(string.Join(" ", arr));

            Sort.Selection<int>(arr);

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
