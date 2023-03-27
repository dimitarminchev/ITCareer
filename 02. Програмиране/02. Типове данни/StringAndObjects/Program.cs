namespace StringAndObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string lineI = Console.ReadLine();
            string lineII = Console.ReadLine();
            object merge = lineI + " " + lineII;
            Console.WriteLine(merge);
        }
    }
}