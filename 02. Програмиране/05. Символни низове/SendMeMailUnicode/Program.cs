namespace SendMeMailUnicode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var email = Console.ReadLine().Split('@').ToArray();

            double part1sum = 0;
            foreach (var item in email[0])
            {
                part1sum += Char.GetNumericValue(item);
            }

            double part2sum = 0;
            foreach (var item in email[1])
            {
                part2sum += Char.GetNumericValue(item);
            }

            if (part2sum - part1sum >= 0)
            {
                Console.WriteLine("Call her!");
            }
            else
            {
                Console.WriteLine("She is not the one.");
            }
        }
    }
}