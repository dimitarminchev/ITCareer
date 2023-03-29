namespace EnterNumbers
{
    class Program
    {
        public static int ReadNumber(int start, int end)
        {
            var num = int.Parse(Console.ReadLine());
            if (num <= start || num > end) throw new ArgumentException($"value must be between {start} - {end}");
            return num;
        }

        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            int n = 0;
            while (list.Count < 10)
            {
                try
                {
                    list.Add(ReadNumber(n, 100));
                    n = list.Last();
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}