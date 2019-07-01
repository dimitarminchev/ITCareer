using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.LongestMutualEnd
{
    class Program
    {
        // 14. Най-дълъг общ край
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split(' ');
            string[] secondArray = Console.ReadLine().Split(' ');
            ushort leftCounter = Counter(firstArray, secondArray);
            Array.Reverse(firstArray);
            Array.Reverse(secondArray);
            ushort rightCounter = Counter(firstArray, secondArray);
            Console.WriteLine(Math.Max(leftCounter, rightCounter));
        }

        // Преброява и връща броя еднакви поредни думи
        static ushort Counter(string[] firstArray, string[] secondArray)
        {
            ushort count = 0;
            for (ushort i = 0; i < Math.Min(firstArray.Length, secondArray.Length); i++)
            {
                if (firstArray[i] == secondArray[i])
                    count++;
                else
                    break;
            }
            return count;
        }
    }
}
