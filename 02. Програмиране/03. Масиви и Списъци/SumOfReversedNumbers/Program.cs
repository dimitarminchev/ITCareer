namespace SumOfReversedNumbers
{
    internal class Program
    {
        public static string ReverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().ToList();
            var sum = 0;
            foreach (var item in nums)
                sum += int.Parse(ReverseString(item));
            Console.WriteLine(sum);
        }
    }
}