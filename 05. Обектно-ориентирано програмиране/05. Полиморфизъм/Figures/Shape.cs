namespace Figures
{
    public abstract class Shape
    {
        public abstract double Perimeter();

        public abstract double Area();

        public virtual string Draw()
        {
            return "Drawing";
        }
    }
}