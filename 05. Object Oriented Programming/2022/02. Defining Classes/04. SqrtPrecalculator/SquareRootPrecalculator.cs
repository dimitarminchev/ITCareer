/// <summary>
/// Изчисляване на корен квадратен
/// </summary>
public static class SquareRootPrecalculator
{
    private const int MaxValue = 1000;
    private static double[] sqrtValues;

    /// <summary>
    /// Конструктор
    /// </summary>
    static SquareRootPrecalculator()
    {
        sqrtValues = new double[MaxValue + 1];
        for (int i = 1; i <= MaxValue; i++)
            sqrtValues[i] = Math.Sqrt(i);
    }

    /// <summary>
    /// Връща корен квадратен
    /// </summary>
    public static double GetSqrt(int value)
    {
        return sqrtValues[value];
    }
}