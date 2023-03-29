namespace StackOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                StackOfStrings<string> stack = new StackOfStrings<string>();
                stack.Add("112");
                stack.Add("911");
                stack.Add("166");

                Console.WriteLine(String.Join(", ", stack));

                while (!stack.IsEmpty())
                {
                    Console.Write("{0}, ", stack.Pop());
                }

                try
                {
                    Console.WriteLine(stack.Pop());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}