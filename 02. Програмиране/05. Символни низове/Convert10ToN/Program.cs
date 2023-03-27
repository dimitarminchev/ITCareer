namespace Convert10ToN
{
    internal class Program
    {
        static string Convert(int number, int target)
        {
            string result = String.Empty;
            while (number > 0)
            {
                var remainder = number % target;
                result = string.Concat(remainder.ToString(), result);
                number = number / target;
            }
            return result;
        }

        static void Main(string[] args)
        {
            var line = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int target = line[0];
            int number = line[1];
            Console.WriteLine(Convert(number, target));
        }
    }
}