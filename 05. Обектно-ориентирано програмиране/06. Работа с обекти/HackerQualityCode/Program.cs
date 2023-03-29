namespace HackerQualityCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Spy spy = new Spy();
            string newResult = spy.AnalyzeAcessModifiers("Hacker");
            Console.WriteLine(newResult);
        }
    }
}