using System;

namespace SumExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ръчно тестване
            if (Sumator.Sum(new int[] { 1, 2 }) != 3)
            {
                throw new Exception("1+2 != 3");
            }
            if (Sumator.Sum(new int[] { -2 }) != -2)
            {
                throw new Exception("-2 != -2");
            }
            if (Sumator.Sum(new int[] { }) != 0)
            {
                throw new Exception("0 != 0");
            }
        }
    }
}
