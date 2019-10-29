using System;

namespace harder_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split(' ');
            string[] secondArray = Console.ReadLine().Split(' ');
            ushort leftCounter = 0, rightCounter = 0;
            leftCounter = Counter(firstArray, secondArray);
            Array.Reverse(firstArray);
            Array.Reverse(secondArray);
            rightCounter= Counter(firstArray, secondArray);
            Console.WriteLine(Math.Max(leftCounter,rightCounter));
        }

        static ushort Counter (string[] firstArray,string [] secondArray)
        //Преброява и връща броя еднакви поредни думи
        {
            ushort count = 0;
            for (ushort i = 0, j = 0; i < firstArray.Length && j < secondArray.Length; i++, j++)
            {
                if (firstArray[i] == secondArray[j])
                    count++;
                else
                    break;
            }
            return count;
        }
    }
}
