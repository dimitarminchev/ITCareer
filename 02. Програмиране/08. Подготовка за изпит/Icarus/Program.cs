namespace Icarus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int start = int.Parse(Console.ReadLine());
            int pos = start, damage = 1;
            var command = Console.ReadLine().Split().ToArray();
            do
            {
                int steps = int.Parse(command[1]);
                if (command[0] == "left")
                {
                    while (steps > 0)
                    {
                        pos--;
                        if (pos < 0)
                        {
                            pos = nums.Length - 1;
                            damage++;
                        }
                        nums[pos] -= damage;
                        steps--;
                    }
                }
                if (command[0] == "right")
                {
                    while (steps > 0)
                    {
                        pos++;
                        if (pos > nums.Length - 1)
                        {
                            pos = 0;
                            damage++;
                        }
                        nums[pos] -= damage;
                        steps--;
                    }
                }
                command = Console.ReadLine().Split().ToArray();
            }
            while (command[0] != "Supernova");
            Console.WriteLine(String.Join(" ", nums));
        }
    }
}