namespace _632
{
    internal class Program
    {
        // 632
        static void Main(string[] args)
        {
            Spy spy = new Spy();

            string newResult = spy.AnalyzeAcessModifiers("Hacker");

            Console.WriteLine(newResult);
        }
    }
}