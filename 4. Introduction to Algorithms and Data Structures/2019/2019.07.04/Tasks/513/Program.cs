using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _513
{
    class Program
    {
        // Автор: Здравко Въндев
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = arr.Length;
            int x = int.Parse(Console.ReadLine());
            if (Search.fibMonaccianSearch(arr, x, n) != -1)
            Console.WriteLine("Found at index: {0}", Search.fibMonaccianSearch(arr, x, n));
            else Console.WriteLine("Not Found");
        }
    }
}
