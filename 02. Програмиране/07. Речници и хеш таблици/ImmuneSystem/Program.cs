namespace ImmuneSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int health = int.Parse(Console.ReadLine());
            int originalhealth = health;
            string virus = Console.ReadLine();
            var encountered = new Dictionary<string, int>();
            string previousvirus = string.Empty;

            while (true)
            {
                if (encountered.ContainsKey(virus))
                {
                    encountered[virus] += 1;
                }
                else
                {
                    encountered[virus] = 1;
                }

                int power = 0;
                foreach (var ch in virus)
                {
                    power += (int)ch;
                }
                power /= 3;

                int time = power * virus.Length;
                if (encountered[virus] > 1 && previousvirus != virus)
                {
                    time /= 3;
                }
                health -= time;

                Console.WriteLine($"Virus {virus}: {power} => {time} seconds");

                if (health <= 0)
                {
                    Console.WriteLine("Immune System Defeated.");
                    break;
                }
                else
                {
                    Console.WriteLine($"{virus} defeated in {time / 60}m {time % 60}s.");
                    Console.WriteLine($"Remaining health: {health}");
                    health = health + (health * 20) / 100;
                    if (health > originalhealth)
                    {
                        health = originalhealth;
                    }
                }

                previousvirus = virus;
                virus = Console.ReadLine();

                if (virus == "end")
                {
                    Console.WriteLine($"Final Health: {health}");
                    break;
                }
            }
        }
    }
}