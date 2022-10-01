/// <summary>
/// Клас за математически операции
/// </summary>
public class MathOperation
{
    /// <summary>
    /// Презареждането (Overloading)
    /// </summary>
    public int Add(int a, int b)
    {
        return a + b;
    }

    /// <summary>
    /// Презареждането (Overloading)
    /// </summary>
    public double Add(double a, double b, double c)
    {
        return a + b + c;
    }

    /// <summary>
    /// Презареждането (Overloading)
    /// </summary>
    public decimal Add(decimal a, decimal b, decimal c)
    {
        return a + b + c;
    }
}