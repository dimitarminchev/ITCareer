namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            LinkedList<string> list = new LinkedList<string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                switch (input[0])
                {
                    case "Add":
                        {
                            list.Add(input[1]);
                            break;
                        }
                    case "Remove":
                        {
                            list.Remove(input[1]);
                            break;
                        }
                }
            }

            Console.WriteLine(list.Count);
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
        }
    }
}