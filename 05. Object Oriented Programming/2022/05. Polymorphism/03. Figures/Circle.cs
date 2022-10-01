/// <summary>
/// Derivative Class
/// </summary>
public sealed class Circle : Shape
{
    public double Radius { get; set; }

    /// <summary>
    /// Contructor
    /// </summary>
    public Circle(double radius)
    {
        Radius = radius;
    }

    /// <summary>
    /// Calculate Perimeter of the Shape
    /// </summary>
    public override double Perimeter()
    {
        return 2 * Math.PI * Radius;
    }

    /// <summary>
    /// Calculate Area of the Shape
    /// </summary>
    public override double Area()
    {
        // return Math.PI * Radius * Radius; // v1
        return Math.PI * Math.Pow(Radius, 2); // v2
    }

    /// <summary>
    /// Overriding
    /// </summary>
    public override string Draw()
    {
        return base.Draw() + " Circle"; // Drawing Circle
    }
}