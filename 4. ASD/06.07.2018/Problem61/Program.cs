using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem61
{
    class Program {
        // 1. Обръщане последователността на масив
        private static void ReverseArray(int[] array, int pos) {
            if (pos >= array.Count()) return;
            ReverseArray(array.Skip(1).ToArray(), pos++);
            Console.Write("{0} ", array[pos - 1]);
        }

        // 3. Комбинации с повторения
        public static void CombinationRepeat<T>(T[] array, int k) {
            T[] vector = new T[k];
            CombinationRepeatAlgo(array, vector, 0, 0);
        }
        private static void CombinationRepeatAlgo<T>(T[] array, T[] vector, int index, int start) {
            if (index >= vector.Length) {
                Console.WriteLine(string.Join(" ", vector));
            }
            else {
                for (int i = start; i < array.Length; i++) {
                    vector[index] = array[i];
                    CombinationAlgo(array, vector, index + 1, i);
                }
            }
        }

        // 5. Комбинация без повторения
        public static void Combination<T>(T[] array, int k) {
            T[] vector = new T[k];
            CombinationAlgo(array, vector, 0, 0);
        }
        private static void CombinationAlgo<T>(T[] array, T[] vector, int index, int start) {
            if (index >= vector.Length) {
                Console.WriteLine(string.Join(" ", vector));
            }
            else {
                for (int i = start; i < array.Length; i++) {
                    vector[index] = array[i];
                    CombinationAlgo(array, vector, index + 1, i + 1);
                }
            }
        }

        // Размяна на елементи
        public static void Swap<T>(T[] array, int first, int second) {
            T temp = array[first];
            array[first] = array[second];
            array[second] = temp;
        }

        // Problem 6.1
        static void Main(string[] args) {
            // Menu
            Console.WriteLine("1. Обръщане последователността на масив");
            Console.WriteLine("2. Вложени цикли и рекурсия");
            Console.WriteLine("3. Комбинация с повторения");
            Console.WriteLine("4. Ханойски кули");
            Console.WriteLine("5. Комбинации без повторения");
            Console.WriteLine("6. Свързани масиви в матрица");
            Console.Write("Моля изберете решение [от 1 до 6]: ");
            var selection = int.Parse(Console.ReadLine());

            // 1. Обръщане последователността на масив
            if (selection == 1) {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                ReverseArray(numbers, 0);
            }

            // 2. Вложени цикли и рекурсия
            if (selection == 2) {
                var n = int.Parse(Console.ReadLine());
                CancerProgram.PrintLoop(n);
            }

            // 3. Комбинация с повторения
            if (selection == 3) {
                int n = int.Parse(Console.ReadLine());
                int k = int.Parse(Console.ReadLine());
                int[] array = new int[n];
                for (int i = 1; i <= n; i++) array[i - 1] = i;
                CombinationRepeat(array, k);
            }

            // 4. Ханойски кули
            if (selection == 4) {
                Console.WriteLine("Not Implemented Yet!");
            }

            // 5. Комбинации без повторения
            if (selection == 5) {
                int n = int.Parse(Console.ReadLine());
                int k = int.Parse(Console.ReadLine());
                int[] array = new int[n];
                for (int i = 1; i <= n; i++) array[i - 1] = i;
                Combination(array, k);

            }

            // 6. Свързани масиви в матрица
            if (selection == 6) {
                Console.WriteLine("Not Implemented Yet!");
            }
        }
    }

    public static class CancerProgram {
        static int[] arr;
        static int num;
        static int cNum;

        internal static void PrintLoop(int n) {
            num = n;
            arr = new int[n];
            Loop();
        }

        private static void Loop() {
            for (int i = 1; i <= num; i++) {
                arr[cNum] = i;
                if (cNum == num - 1) {
                    Console.WriteLine(string.Join(" ", arr));
                }
                else {
                    cNum++;
                    Loop();
                }
            }
            cNum--;
        }
    }
}