using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MostCommonNumber
{
    class Program
    {
        // 2. Най-често срещано число
        static void Main(string[] args)
        {
            // Входни данни
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            // Намираме броя на срещанията на всяко число
            int[] count = new int[65535];
            for (int i = 0; i < array.Length; i++)
                count[array[i]]++;

            // Намираме най-често срещаното число
            int maxValue = count[0], maxIndex = 0;
            for (int i = 0; i < count.Length; i++)
                if (count[i] > maxValue)
                {
                    maxValue = count[i];
                    maxIndex = i;
                } 
            Console.WriteLine(maxIndex);

            // TODO: При равен брой срещания намерете най-лявото
        }
    }
}
