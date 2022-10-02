namespace _633
{
    internal class Program
    {
        // 633
        static void Main(string[] args)
        {
            Spy spy = new Spy();

            string result = spy.RevealPrivateMethods("Hacker");

            Console.WriteLine(result);
        }
    }
}