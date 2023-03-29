namespace KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string[]> input = () => Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            Action<string[]> output = (inp) => Console.WriteLine("Sir " + string.Join("\nSir ", inp));
            output(input());
        }
    }
}