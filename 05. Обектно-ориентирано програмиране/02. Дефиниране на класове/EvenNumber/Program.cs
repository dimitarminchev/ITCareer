namespace EvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            OddEven checker = new OddEven();

            List<int> numbers = new List<int>();
            numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            foreach (var number in numbers)
            {
                if (checker.IsEven(number))
                {
                    Console.WriteLine("{0} => Even", number);
                }
            }
        }
    }
}