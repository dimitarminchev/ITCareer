using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3
{
    static class SquareRoot
    {
        // Полета
        private static int max = 1000;
        private static double[] values;

        // Статичен конструктор
        static SquareRoot()
        {
            values = new double[max + 1];
            for (int i = 1; i <= max; i++) values[i] = Math.Sqrt(i);
        }

        // Метод
        public static double Sqrt(int value)
        {
            return values[value];
        }

    }
}
