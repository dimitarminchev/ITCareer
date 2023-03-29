namespace RationalNumber
{
    public class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            List<RationalNumber> rationals = new List<RationalNumber>();

            for (int i = 0; i < input.Length; i += 2)
            {
                rationals.Add
                (
                    new RationalNumber(input[i], input[i + 1])
                );
            }

            Console.WriteLine(string.Join(Environment.NewLine, rationals));
        }
    }
}