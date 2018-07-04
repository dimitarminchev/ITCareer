using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem43 {
    class Program {
        static void Main(string[] args) {
            int number = int.Parse(Console.ReadLine());
            if (number == 4) {
                var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                Sorting.SortCount(arr);
            }
            else if (number == 5) {
                var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                Sorting.SortMerge(arr);
                Console.WriteLine(string.Join(" ", arr));
                int maxN = 0, maxL = 0, length = 0;
                for (int i = 0; i < arr.Length - 1; i++) {
                    if (arr[i] == arr[i + 1])
                        length++;
                    else length = 0;
                    if (length > maxL) {
                        maxL = length;
                        maxN = arr[i];
                    }
                    else if (length == maxL && maxN < arr[i])
                        maxN = arr[i];
                }
                Console.WriteLine((maxL + 1) + " " + maxN);
            }
            else if (number == 6) {
                // мързи ме
            }
            else if (number == 7) {
                // за тази още повече
            }
        }
    }
}
