using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_SquareRoot
{
    class SquareRootPrecalculator
    {
        // Брой корен квадратите, които ще бъдат предварително изчислени
        public const int MaxValue = 1000;

        // Масив съдържащ корен квадратите
        private static double[] sqrtValues;

        // Конструктор
        static SquareRootPrecalculator()
        {
            // Създаваме нов масив с MaxValue на брой елемента
            sqrtValues = new double[MaxValue + 1];

            // Изчисляваме корен квадрати до MaxValue и ги записваме в sqrtValues
            for (int i = 1; i <= MaxValue; i++)
            {
                sqrtValues[i] = Math.Sqrt(i);
            }
        }

        // Взимане на конкретен корен на дадено число
        public static double GetSqrt(int number)
        {
            return sqrtValues[number];
        }
    }
}
