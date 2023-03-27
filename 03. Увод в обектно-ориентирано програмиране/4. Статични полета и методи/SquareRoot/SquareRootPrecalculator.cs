namespace SquareRoot
{
    class SquareRootPrecalculator
    {
        public const int MaxValue = 1000;

        private static double[] sqrtValues;

        static SquareRootPrecalculator()
        {
            sqrtValues = new double[MaxValue + 1];

            for (int i = 1; i <= MaxValue; i++)
            {
                sqrtValues[i] = Math.Sqrt(i);
            }
        }

        public static double GetSqrt(int number)
        {
            return sqrtValues[number];
        }
    }
}
