namespace _05._StackOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create new stack
            StackOfStrings<string> stack = new StackOfStrings<string>();

            // Add some data to the stack
            stack.Add("112");
            stack.Add("911");
            stack.Add("166");

            // Print the stack
            Console.WriteLine(String.Join(", ", stack));

            // Remove all elements from the stack
            while (!stack.IsEmpty())
            {
                Console.Write("{0}, ", stack.Pop());
            }

            // If the stack is empty => Exception
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