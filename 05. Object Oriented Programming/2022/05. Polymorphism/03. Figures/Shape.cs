/// <summary>
/// Abstract Base Class
/// </summary>
public abstract class Shape
{
    /// <summary>
    /// Calculate Perimeter of the Shape
    /// </summary>
    public abstract double Perimeter();

    /// <summary>
    /// Calculate Area of the Shape
    /// </summary>
    public abstract double Area();

    /// <summary>
    /// Print the type of the Shape
    /// </summary>
    public virtual string Draw()
    {
        return "Drawing";
    }
}