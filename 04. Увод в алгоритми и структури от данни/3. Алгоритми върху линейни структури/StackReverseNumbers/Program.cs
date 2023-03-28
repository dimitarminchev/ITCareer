namespace StackReverseNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                stack.Push(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}