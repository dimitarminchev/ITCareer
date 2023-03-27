namespace GrandPrix
{
    public class TyreFactory
    {
        public Tyre CreateTyre(double hardness) => new HardTyre(hardness);

        public Tyre CreateTyre(double hardness, double grip) => new UltrasoftTyre(hardness, grip);
    }
}
