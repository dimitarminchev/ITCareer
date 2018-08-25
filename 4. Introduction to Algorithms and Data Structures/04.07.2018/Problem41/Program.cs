using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem41
{
    class Program
    {
        static void Main(string[] args)
        {
            // menu
            Console.WriteLine("3. Класиране на приема");
            Console.WriteLine("4. Ученици по физическо");
            Console.WriteLine("5. Кросово бягане");
            Console.WriteLine("Избор [3,4,5]: ");
            int n = int.Parse(Console.ReadLine());

            // 3. Класиране на приема
            if (n == 3)
            {
                int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                Sorting.ReversedSelectionSort(input);
                Console.WriteLine(string.Join(" ", input));
            }

            // 4. Ученици по физическо
            if (n == 4)
            {
                int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int[] positions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                Sorting.ReversedSelectionSort(input);
                Console.WriteLine(input[positions[0] - 1] + " " + input[positions[1] - 1]);
            }

            // 5. Кросово бягане
            if (n == 3)
            {
                int[] array1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int[] array2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int[] combinedArray = array1.Concat(array2).ToArray();
                Sorting.SelectionSort(combinedArray);
                Console.WriteLine(string.Join(" ", combinedArray));
            }
        }
    }
}
