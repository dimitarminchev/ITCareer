/// <summary>
/// Derivative Class
/// </summary>
public sealed class Rectangle : Shape
{
    public double Width { get; set; }

    public double Height { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    /// <summary>
    /// Calculate Perimeter of the Shape
    /// </summary>
    public override double Perimeter()
    {
        return 2 * (Height * Width);
    }

    /// <summary>
    /// Calculate Area of the Shape
    /// </summary>
    public override double Area()
    {
        return Height * Width;
    }

    /// <summary>
    /// Example Override
    /// </summary>
    public override string Draw()
    {
        return base.Draw() + " Rectangle"; // Drawing Rectangle
    }
}