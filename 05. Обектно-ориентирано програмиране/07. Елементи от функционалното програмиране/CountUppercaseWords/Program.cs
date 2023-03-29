namespace CountUppercaseWords
{
    internal class Program
    {
        /// <summary>
        /// Count Uppercase Words
        /// https://judge.softuni.org/Contests/Practice/Index/597#2
        /// </summary>
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
                        .Split(new string[] { " " },
                        StringSplitOptions.RemoveEmptyEntries);

            Func<string, bool> checker = n => n[0] == n.ToUpper()[0];

            words.Where(checker)
                 .ToList()
                 .ForEach(n => Console.WriteLine(n));
        }
    }
}