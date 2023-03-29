namespace TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Func<string[]> input = () => Console.ReadLine()
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();
            Func<string, bool> isBigger = (inpu) => inpu.ToCharArray().Sum(x => x) >= 800;
            Action<string[]> output = (inp) =>
            {
                foreach (var item in inp)
                {
                    if (isBigger(item))
                        Console.WriteLine(item);
                };
            };
            output(input());
        }
    }
}