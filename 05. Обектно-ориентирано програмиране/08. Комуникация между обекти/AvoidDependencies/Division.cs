namespace AvoidDependencies
{
    public class Division : IStrategy
    {
        public int Calculate(int first, int second)
        {
            return first / second;
        }
    }
}
