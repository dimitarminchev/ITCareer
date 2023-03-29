namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();

            List<string> input = Console.ReadLine().Split(' ').ToList();

            while (input[0] != "END")
            {
                switch (input[0])
                {
                    case "Push":
                        input.RemoveAt(0);

                        for (int i = 0; i < input.Count; i++)
                        {
                            input[i] = input[i].Replace(",", "");
                            stack.Push(input[i]);
                        }

                        break;
                    case "Pop":
                        stack.Pop();
                        break;
                }

                input = Console.ReadLine().Split(' ').ToList();
            }

            List<string> reversed = new List<string>();

            foreach (string item in stack)
            {
                reversed.Add(item);
            }

            reversed.Reverse();

            foreach (string item in reversed)
            {
                Console.WriteLine(item);
            }
            foreach (string item in reversed)
            {
                Console.WriteLine(item);
            }
        }
    }
}