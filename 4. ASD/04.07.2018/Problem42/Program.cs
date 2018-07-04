using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem42 {
    class Program {
        static void Main(string[] args) {
            int number = int.Parse(Console.ReadLine());
            if (number == 4) {
                int n = int.Parse(Console.ReadLine());
                var input = Console.ReadLine().Split(' ').Select(int.Parse);
                var arr1 = input.Take(n / 2).ToArray();
                var arr2 = input.Skip(n / 2).ToArray();
                Sorting.SortBy(arr1);
                Sorting.SortByDescending(arr2);
                Console.WriteLine(string.Join(" ", arr1) + " " + string.Join(" ", arr2));
            }
            else if (number == 5) {
                var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                var d2arr = new int[input[0]][];
                var sort = new int[input[1]];
                for (int r = 0; r < input[0]; r++) {
                    d2arr[r] = new int[input[1]];
                    var arr = Console.ReadLine().Split(' ');
                    for (int c = 0; c < input[1]; c++)
                        d2arr[r][c] = int.Parse(arr[c]);
                }
                Sorting.Sort2D(d2arr, input[2] - 1);
                for (int r = 0; r < input[0]; r++)
                    Console.WriteLine(string.Join(" ", d2arr[r]));
            }
        }
    }
}
