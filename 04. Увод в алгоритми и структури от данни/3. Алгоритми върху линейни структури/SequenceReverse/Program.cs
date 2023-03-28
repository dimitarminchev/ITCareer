namespace SequenceReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            int n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                var number = int.Parse(Console.ReadLine());
                stack.Push(number);
                n--;
            }

            foreach (var item in stack)
            {
                Console.Write("{0} ", item);
            }
        }
    }
}