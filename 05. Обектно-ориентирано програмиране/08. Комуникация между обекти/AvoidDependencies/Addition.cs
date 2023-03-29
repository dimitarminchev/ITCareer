namespace AvoidDependencies
{
    public class Addition : IStrategy
    {
        public int Calculate(int first, int second)
        {
            return first + second;
        }
    }
}
