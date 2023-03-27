namespace DatesDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstDate = Console.ReadLine();
            var secondDate = Console.ReadLine();

            DateModifier date = new DateModifier();
            date.SetDates(firstDate, secondDate);

            Console.WriteLine(date.Difference());
        }
    }
}