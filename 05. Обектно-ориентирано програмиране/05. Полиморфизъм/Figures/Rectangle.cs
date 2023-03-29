namespace Figures
{
    public sealed class Rectangle : Shape
    {
        public double Width { get; set; }

        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double Perimeter()
        {
            return 2 * (Height * Width);
        }

        public override double Area()
        {
            return Height * Width;
        }

        public override string Draw()
        {
            return base.Draw() + " Rectangle"; 
        }
    }
}