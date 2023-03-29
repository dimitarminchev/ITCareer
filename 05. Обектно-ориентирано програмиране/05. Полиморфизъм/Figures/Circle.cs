namespace Figures
{
    public sealed class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2); 
        }

        public override string Draw()
        {
            return base.Draw() + " Circle"; 
        }
    }
}