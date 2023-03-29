namespace AvoidDependencies
{
    class Multiplying : IStrategy
    {
        public int Calculate(int first, int second)
        {
            return first * second;
        }
    }
}
